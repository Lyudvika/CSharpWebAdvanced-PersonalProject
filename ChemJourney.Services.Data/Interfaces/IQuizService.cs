using ChemJourney.Web.ViewModels.Quiz;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface IQuizService
    {
        Task<bool> ExistsByIdAsync(int id);
        Task<IEnumerable<QuizAllViewModel>> GetQuizzesAsync();
        Task<QuizViewModel> GetQuizByIdAsync(int id);
        Task<int> CalculateQuizScoreAsync(int quizId, Dictionary<int, string> selectedOptions);
        Task<int> SaveQuizScoreAndReturnIdAsync(string userId, int quizId, int score);
        Task<QuizScoreViewModel> GetQuizScoreByIdAsync(int id);
    }
}
