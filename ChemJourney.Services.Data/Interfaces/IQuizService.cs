using ChemJourney.Web.ViewModels.Quiz;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface IQuizService
    {
        Task<IEnumerable<QuizAllViewModel>> GetQuizzesAsync();
    }
}
