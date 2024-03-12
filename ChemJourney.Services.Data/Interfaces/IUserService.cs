namespace ChemJourney.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<bool> IsUserOwnerOfPostById(string userId, int postId);
        Task<bool> IsUserOwnerOfPostReplyById(string userId, int replyId);
    }
}
