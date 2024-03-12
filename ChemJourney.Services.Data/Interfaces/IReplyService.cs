using ChemJourney.Web.ViewModels.Reply;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface IReplyService
    {
        Task<bool> ExistsByIdAsync(int replyId);
        Task AddReplyAsync(PostReplyFormViewModel model, string userId, int id);
        Task<PostReplyFormViewModel> GetForEditOrDeleteByIdAsync(int id);
        Task EditReplyAsync(PostReplyFormViewModel model, int id);
        Task DeleteReplyAsync(int id);
        Task<int> GetPostId(int id);
    }
}
