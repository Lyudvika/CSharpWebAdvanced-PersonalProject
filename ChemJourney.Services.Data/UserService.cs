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
        public async Task<bool> IsUserOwnerOfPostByIdAsync(string userId, int postId)
        {
            return await dbContext
                .Posts
                .Where(p => p.AuthorId == Guid.Parse(userId))
                .AnyAsync(p => p.Id == postId);
        }

        public async Task<bool> IsUserOwnerOfPostReplyByIdAsync(string userId, int replyId)
        {
            return await dbContext
                .PostReplies
                .Where(pr => pr.AuthorId == Guid.Parse(userId))
                .AnyAsync(pr => pr.Id == replyId);
        }

        public async Task<bool> IsUserOwnerOfQuizScoreByIdAsync(string userId, int quizScoreId)
        {
            return await dbContext
                .QuizScores
                .Where(qs => qs.UserId == Guid.Parse(userId))
                .AnyAsync(qs => qs.Id == quizScoreId);
        }
    }
}
