using ChemJourney.Web.ViewModels.Forum;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostAllViewModel>> GetPostsAsync();
    }
}
