using ChemJourney.Web.ViewModels.Quiz;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface IQuizService
    {
        Task<bool> ExistsByIdAsync(int id);
        Task<IEnumerable<QuizAllViewModel>> GetQuizzesAsync();
        Task<QuizViewModel> GetQuizById(int id);
        Task<int> CalculateQuizScore(int quizId, Dictionary<int, string> selectedOptions);
    }
}
