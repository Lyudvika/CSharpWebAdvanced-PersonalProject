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
    }
}
