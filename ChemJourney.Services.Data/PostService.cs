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

		public async Task<IEnumerable<PostAllViewModel>> GetPostsByCategoryAsync(string category)
		{
			IEnumerable<PostAllViewModel> posts = await this.dbContext
				.Posts
				.Where(p => p.Category.Name == category)
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

		public async Task AddPostAsync(PostFormViewModel model, string userId)
		{
			Post post = new Post()
			{
				Title = model.Title,
				Content = model.Content,
				CategoryId = model.CategoryId,
				DateTime = DateTime.UtcNow,
				WriterId = Guid.Parse(userId)
			};

			await this.dbContext.Posts.AddAsync(post);
			await this.dbContext.SaveChangesAsync();
		}

		public Task<PostFormViewModel> EditPostAsync(int postId, string newContent)
		{
			throw new NotImplementedException();
		}

		public Task DeletePostAsync(string postId)
		{
			throw new NotImplementedException();
		}

		public Task<PostReplyViewModel> AddReplyAsync(PostReplyViewModel model)
		{
			throw new NotImplementedException();
		}

		public Task<PostReplyViewModel> EdinPostReplyAsync(int replyId, string newContemt)
		{
			throw new NotImplementedException();
		}

		public Task DeleteReplyAsync(string replyId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync()
		{
			return await dbContext.Categories
				.AsNoTracking()
				.Select(t => new CategoryViewModel
				{
					Id = t.Id,
					Name = t.Name
				})
				.ToListAsync();
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
