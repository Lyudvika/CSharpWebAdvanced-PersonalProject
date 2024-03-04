using ChemJourney.Data.Models;
using ChemJourney.Web.ViewModels.Post;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostAllViewModel>> GetPostsAsync();
        Task<IEnumerable<PostAllViewModel>> GetPostsByCategoriesAsync(string category);

        Task<PostDetailsViewModel> GetPostById(int postId);
        Task<PostFormViewModel> AddPostAsync(PostFormViewModel post);
        Task DeletePostAsync(string postId);
        Task<PostFormViewModel> EditPostAsync(int postId, string newContent);

        Task<PostReplyViewModel> EdinPostReplyAsync(int postId, string newContemt);

        Task AddReply(PostReply reply);
    }
}
