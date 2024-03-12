using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.Post;
using Microsoft.EntityFrameworkCore;

namespace ChemJourney.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly ChemJourneyDbContext dbContext;

        public CategoryService(ChemJourneyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync()
        {
            return await dbContext
                .Categories
                .AsNoTracking()
                .Select(t => new CategoryViewModel
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToListAsync();
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            return await dbContext
                .Categories
                .AnyAsync(p => p.Id == id);
        }
    }
}
