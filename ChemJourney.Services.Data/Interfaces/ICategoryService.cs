using ChemJourney.Web.ViewModels.Post;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();

        Task<bool> ExistsByIdAsync(int id);
    }
}
