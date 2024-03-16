namespace ChemJourney.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<bool> IsUserOwnerOfPostByIdAsync(string userId, int postId);
        Task<bool> IsUserOwnerOfPostReplyByIdAsync(string userId, int replyId);
        Task<bool> IsUserOwnerOfQuizScoreByIdAsync(string userId, int quizScoreId);
    }
}
