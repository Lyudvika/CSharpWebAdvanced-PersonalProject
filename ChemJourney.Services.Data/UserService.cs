using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace ChemJourney.Services.Data
{
    public class UserService : IUserService
    {
        private readonly ChemJourneyDbContext dbContext;

        public UserService(ChemJourneyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<bool> IsUserOwnerOfPostById(string userId, int postId)
        {
            return await dbContext
                .Posts
                .Where(p => p.AuthorId == Guid.Parse(userId))
                .AnyAsync(p => p.Id == postId);
        }
    }
}
