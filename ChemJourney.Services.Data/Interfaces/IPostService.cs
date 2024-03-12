using ChemJourney.Web.ViewModels.Post;

namespace ChemJourney.Services.Data.Interfaces
{
	public interface IPostService
    {
        Task<IEnumerable<PostAllViewModel>> GetPostsAsync();
        Task<PostDetailsViewModel> GetPostById(int id);
        Task<IEnumerable<PostAllViewModel>> GetPostsByCategoryAsync(string category);

        Task AddPostAsync(PostFormViewModel model, string userId);
        Task<PostFormViewModel> GetForEditOrDeleteByIdAsync(int id);
        Task EditPostAsync(PostFormViewModel model, int id);
        Task DeletePostAsync(int id);
	}
}
