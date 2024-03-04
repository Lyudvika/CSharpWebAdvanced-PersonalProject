using ChemJourney.Data.Models;
using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.Post;
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
					AuthorName = p.Writer.UserName,
					RepliesCount = p.PostReplies.Count
				}).ToArrayAsync();

			return posts;
		}

		public Task<IEnumerable<PostAllViewModel>> GetPostsByCategoriesAsync(string category)
		{
			throw new NotImplementedException();
		}

		public async Task<PostDetailsViewModel> GetPostById(int postId)
		{
			var model = await dbContext
				.Posts
				.Where(p => p.Id == postId)
				.Include(p => p.PostReplies)
				.AsNoTracking()
				.Select(p => new PostDetailsViewModel()
				{
					Id = p.Id,
					Title = p.Title,
					Content = p.Content,
					Category = p.Category.Name,
					AuthorId = p.WriterId.ToString(),
					AuthorName = p.Writer.UserName,
					PostCreated = p.DateTime,
					PostReplies = GetPostReplies(p.PostReplies)
				})
				.FirstOrDefaultAsync();

			if (model == null)
				throw new InvalidOperationException("Post not found.");

			return model;
		}

		public Task<PostFormViewModel> AddPostAsync(PostFormViewModel post)
		{
			throw new NotImplementedException();
		}

		public Task<PostFormViewModel> EditPostAsync(int postId, string newContent)
		{
			throw new NotImplementedException();
		}

		public Task AddReply(PostReply reply)
		{
			throw new NotImplementedException();
		}

		public Task<PostReplyViewModel> EdinPostReplyAsync(int postId, string newContemt)
		{
			throw new NotImplementedException();
		}

		public Task DeletePostAsync(string postId)
		{
			throw new NotImplementedException();
		}

		private static IEnumerable<PostReplyViewModel> GetPostReplies(IEnumerable<PostReply> replies)
		{
			return replies
				.Select(r => new PostReplyViewModel()
				{
					Id = r.Id,
					Content = r.Content,
					AuthorId = r.ReplierId.ToString(),
					AuthorName = r.Replier.UserName,
					ReplyCreated = r.DateTime,
				})
				.ToArray();
		}
	}
}
