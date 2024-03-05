using ChemJourney.Web.ViewModels.Post;

namespace ChemJourney.Services.Data.Interfaces
{
	public interface IPostService
    {
        Task<IEnumerable<PostAllViewModel>> GetPostsAsync();
        Task<PostDetailsViewModel> GetPostById(int postId);
        Task<IEnumerable<PostAllViewModel>> GetPostsByCategoryAsync(string category);

        Task AddPostAsync(PostFormViewModel model, string userId);
		Task<PostFormViewModel> EditPostAsync(int postId, string newContent);
        Task DeletePostAsync(string postId);

        Task<PostReplyViewModel> AddReplyAsync(PostReplyViewModel model);
        Task<PostReplyViewModel> EdinPostReplyAsync(int replyId, string newContemt);
		Task DeleteReplyAsync(string replyId);

        Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();
	}
}
