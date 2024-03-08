using ChemJourney.Data.Models;
using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.Post;
using ChemJourney.Web.ViewModels.Reply;
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
				.Where( p=> p.IsDeleted == false)
				.Select(p => new PostAllViewModel
				{
					Id = p.Id,
					Title = p.Title,
					Content = p.Content,
					Category = p.Category.Name,
					DateTime = p.DateTime.ToString(),
					AuthorName = p.Author.UserName,
					RepliesCount = p.PostReplies.Count
				}).ToArrayAsync();

			return posts;
		}

		public async Task<PostDetailsViewModel> GetPostById(int id)
		{
			var model = await dbContext
				.Posts
				.Where(p => p.IsDeleted == false)
				.Where(p => p.Id == id)
				.Include(p => p.PostReplies)
				.AsNoTracking()
				.Select(p => new PostDetailsViewModel()
				{
					Id = p.Id,
					Title = p.Title,
					Content = p.Content,
					Category = p.Category.Name,
					AuthorId = p.AuthorId.ToString(),
					AuthorName = p.Author.UserName,
					PostCreated = p.DateTime,
				})
				.FirstOrDefaultAsync();

			if (model == null)
				throw new InvalidOperationException("Post not found.");

            model.PostReplies = await GetPostReplies(id);

            return model;
		}

		public async Task<IEnumerable<PostAllViewModel>> GetPostsByCategoryAsync(string category)
		{
			IEnumerable<PostAllViewModel> posts = await this.dbContext
				.Posts
                .Where(p => p.IsDeleted == false)
                .Where(p => p.Category.Name == category)
				.Select(p => new PostAllViewModel
				{
					Id = p.Id,
					Title = p.Title,
					Content = p.Content,
					Category = p.Category.Name,
					DateTime = p.DateTime.ToString(),
					AuthorName = p.Author.UserName,
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
				AuthorId = Guid.Parse(userId)
			};

			await this.dbContext.Posts.AddAsync(post);
			await this.dbContext.SaveChangesAsync();
		}

		public async Task<PostFormViewModel> GetForEditOrDeleteByIdAsync(int id)
		{
			Post postToEdit = await this.dbContext
				.Posts
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id == id);

			return new PostFormViewModel()
			{
				Title = postToEdit.Title,
				Content = postToEdit.Content,
				CategoryId = postToEdit.CategoryId,
				AuthorId = postToEdit.AuthorId.ToString()
			};
		}

		public async Task EditPostAsync(PostFormViewModel model, int id)
		{
            Post postToEdit = await this.dbContext
                .Posts
                .Where(p => p.IsDeleted == false)
                .FirstAsync(p => p.Id == id);

            postToEdit.Title = model.Title;
            postToEdit.Content = model.Content;
			postToEdit.CategoryId = model.CategoryId;

            await this.dbContext.SaveChangesAsync();
        }

		public async Task DeletePostAsync(int id)
		{
			Post post = await this.dbContext
				.Posts
				.FirstAsync(p => p.Id == id);

			post.IsDeleted = true;
			await this.dbContext.SaveChangesAsync();
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

		private async Task<IEnumerable<PostReplyFormViewModel>> GetPostReplies(int id)
		{
            return await dbContext
                .PostReplies
                .Where(r => r.IsDeleted == false)
                .Where(r => r.PostId == id)
                .AsNoTracking()
                .Select(r => new PostReplyFormViewModel()
				{
					Id = r.Id,
					Content = r.Content,
					AuthorId = r.AuthorId.ToString(),
					AuthorName = r.Author.UserName,
					ReplyCreated = r.DateTime,
				})
				.ToListAsync();
		}
	}
}
