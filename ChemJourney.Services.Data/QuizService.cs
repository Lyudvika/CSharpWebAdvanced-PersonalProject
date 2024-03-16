using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.Quiz;
using Microsoft.EntityFrameworkCore;

namespace ChemJourney.Services.Data
{
    public class QuizService : IQuizService
    {
        private readonly ChemJourneyDbContext dbContext;

        public QuizService(ChemJourneyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            return await dbContext
                .Quizzes
                .AnyAsync(q => q.Id == id);
        }

        public async Task<IEnumerable<QuizAllViewModel>> GetQuizzesAsync()
        {
            IEnumerable<QuizAllViewModel> quizzes = await this.dbContext
                .Quizzes
                .Select(q => new QuizAllViewModel
                {
                    Id = q.Id,
                    Title = q.Title,
                    Description = q.Description,
                    Category = q.Category.Name,
                })
                .ToArrayAsync();

            return quizzes;
        }

        public async Task<QuizViewModel> GetQuizById(int id)
        {
            var model = await dbContext
                .Quizzes
                .Where(q => q.Id == id)
                .Include(q => q.QuizQuestions)
                .AsNoTracking()
                .Select(q => new QuizViewModel()
                {
                    Id = q.Id,
                    Title = q.Title,
                    Description = q.Description,
                    Category = q.Category.Name,
                })
                .FirstOrDefaultAsync();

            if (model == null)
                throw new InvalidOperationException("Quiz not found.");

            model.QuizQuestions = await GetQuizQuestions(id);

            return model;
        }

        public async Task<int> CalculateQuizScore(int quizId, Dictionary<int, string> selectedOptions)
        {
            var correctAnswers = await GetCorrectAnswersForQuiz(quizId);

            int score = 0;

            foreach (var questionId in selectedOptions.Keys)
            {
                string selectedOption = selectedOptions[questionId];

                if (correctAnswers.TryGetValue(questionId, out string correctOption) && selectedOption == correctOption)
                {
                    score++;
                }
            }

            return score;
        }

        private async Task<Dictionary<int, string>> GetCorrectAnswersForQuiz(int quizId)
        {
            var quizQuestions = await dbContext.QuizQuestions
            .Where(qq => qq.QuizId == quizId)
            .Select(qq => new { qq.Id, qq.CorrectOption })
            .ToListAsync();

            return quizQuestions.ToDictionary(qq => qq.Id, qq => qq.CorrectOption);
        }

        private async Task<IEnumerable<QuizQuestionsViewModel>> GetQuizQuestions(int id)
        {
            return await dbContext
                .QuizQuestions
                .Where(qq => qq.QuizId == id)
                .AsNoTracking()
                .Select(qq => new QuizQuestionsViewModel()
                {
                    Id = qq.Id,
                    QuestionText = qq.QuestionText,
                    Options = new List<string>
                    {
                        qq.OptionOne,
                        qq.OptionTwo,
                        qq.OptionThree,
                        qq.OptionFour
                    }
                })
                .ToListAsync();
        }
    }
}
