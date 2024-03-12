using ChemJourney.Data.Models;
using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.Reply;
using Microsoft.EntityFrameworkCore;

namespace ChemJourney.Services.Data
{
    public class ReplyService : IReplyService
    {
        private readonly ChemJourneyDbContext dbContext;

        public ReplyService(ChemJourneyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> ExistsByIdAsync(int replyId)
        {
            return await dbContext
                .PostReplies
                .Where(p => p.IsDeleted == false)
                .AnyAsync(p => p.Id == replyId);
        }

        public async Task AddReplyAsync(PostReplyFormViewModel model, string userId, int id)
        {
            PostReply postReply = new()
            {
                Content = model.Content,
                DateTime = DateTime.UtcNow,
                AuthorId = Guid.Parse(userId),
                PostId = id
            };

            await this.dbContext.PostReplies.AddAsync(postReply);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PostReplyFormViewModel> GetForEditOrDeleteByIdAsync(int id)
        {
            PostReply postToEdit = await this.dbContext
                .PostReplies
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id == id);

            return new PostReplyFormViewModel()
            {
                Content = postToEdit.Content,
                AuthorId = postToEdit.AuthorId.ToString()
            };
        }

        public async Task EditReplyAsync(PostReplyFormViewModel model, int id)
        {
            PostReply postToEdit = await this.dbContext
                .PostReplies
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id == id);

            postToEdit.Content = model.Content;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteReplyAsync(int id)
        {
            PostReply post = await this.dbContext
                .PostReplies
                .FirstAsync(p => p.Id == id);

            post.IsDeleted = true;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> GetPostId(int id)
        {
            return await dbContext
                .PostReplies
                .Where(r => r.Id == id)
                .Select(r => r.PostId)
                .FirstOrDefaultAsync();
        }
    }
}
