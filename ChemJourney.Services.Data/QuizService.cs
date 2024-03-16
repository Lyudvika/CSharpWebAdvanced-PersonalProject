using ChemJourney.Data.Models;
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

        public async Task<QuizViewModel> GetQuizByIdAsync(int id)
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

            model.QuizQuestions = await GetQuizQuestionsAsync(id);

            return model;
        }

        public async Task<int> CalculateQuizScoreAsync(int quizId, Dictionary<int, string> selectedOptions)
        {
            Dictionary<int, string> correctAnswers = await GetCorrectAnswersForQuizAsync(quizId);

            int score = 0;

            foreach (var questionId in selectedOptions.Keys)
            {
                string selectedOption = selectedOptions[questionId];

                if (correctAnswers.TryGetValue(questionId, out string? correctOption) && selectedOption == correctOption)
                {
                    score++;
                }
            }

            return score;
        }

        public async Task<int> SaveQuizScoreAndReturnIdAsync(string userId, int quizId, int score)
        {
            QuizScore quizScore = new()
            {
                UserId = Guid.Parse(userId),
                QuizId = quizId,
                Score = score,
                DateCompleted = DateTime.UtcNow
            };

            await this.dbContext.QuizScores.AddAsync(quizScore);
            await this.dbContext.SaveChangesAsync();

            return quizScore.Id;
        }

        public async Task<QuizScoreViewModel> GetQuizScoreByIdAsync(int id)
        {
            QuizScoreViewModel quizScore= await this.dbContext
                .QuizScores
                .Where(qs => qs.Id == id)
                .Select(q => new QuizScoreViewModel
                {
                    Id = q.Id,
                    Title = q.Quiz.Title,
                    Description = q.Quiz.Description,
                    Score = q.Score
                })
                .FirstAsync();

            return quizScore;
        }

        private async Task<Dictionary<int, string>> GetCorrectAnswersForQuizAsync(int quizId)
        {
            var quizQuestions = await dbContext
                .QuizQuestions
                .Where(qq => qq.QuizId == quizId)
                .Select(qq => new { qq.Id, qq.CorrectOption })
                .ToListAsync();

            return quizQuestions.ToDictionary(qq => qq.Id, qq => qq.CorrectOption);
        }

        private async Task<IEnumerable<QuizQuestionsViewModel>> GetQuizQuestionsAsync(int id)
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
