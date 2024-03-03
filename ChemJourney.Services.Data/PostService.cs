using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.Forum;
using Microsoft.EntityFrameworkCore;

namespace ChemJourney.Services.Data
{
    public class PostService : IPostService
    {
        private readonly ChemJourneyDbContext dbContext;

        public PostService(ChemJourneyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<PostAllViewModel>> GetPostsAsync()
        {
            IEnumerable<PostAllViewModel> posts = await this.dbContext
                .Posts
                .Select(p => new PostAllViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content,
                    Category = p.Category.Name,
                    DateTime = p.DateTime.ToString(),
                    Writer = p.Writer.UserName
                }).ToArrayAsync();

            return posts;
        }
    }
}
