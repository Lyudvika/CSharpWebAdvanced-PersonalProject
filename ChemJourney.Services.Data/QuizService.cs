using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;

namespace ChemJourney.Services.Data
{
    public class QuizService : IQuizService
    {
        private readonly ChemJourneyDbContext dbContext;

        public QuizService(ChemJourneyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


    }
}
