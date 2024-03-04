using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<PostAllViewModel> viewModel = await this.postService.GetPostsAsync();
            return View(viewModel);
        }

		public async Task<IActionResult> Details(int postId)
		{
			PostDetailsViewModel viewModel = await this.postService.GetPostById(postId);

			if (viewModel == null)
			{
				return NotFound();
			}

			return View(viewModel);
		}

        public async Task<IActionResult> AllByCategory(string category)
        {
			IEnumerable<PostAllViewModel> viewModel = await this.postService.GetPostsByCategoryAsync(category);
			return View(viewModel);
		}
	}
}
