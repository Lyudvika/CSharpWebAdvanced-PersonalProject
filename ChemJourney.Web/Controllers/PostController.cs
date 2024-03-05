using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ChemJourney.Web.Controllers
{
	public class PostController : Controller
    {
        private readonly IPostService postService;

		public PostController(IPostService postService, ChemJourneyDbContext data)
        {
            this.postService = postService;
		}

        public async Task<IActionResult> All()
        {
            IEnumerable<PostAllViewModel> viewModel = await this.postService.GetPostsAsync();
            return View(viewModel);
        }

		public async Task<IActionResult> Create()
		{
			var model = new PostFormViewModel();
			model.Categories = await postService.GetCategoriesAsync();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Create(PostFormViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			var userId = GetUserId();

			try
			{
				await postService.AddPostAsync(model, userId);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Error! Failed to add the post.");

				return View(model);
			}

			model.Categories = await postService.GetCategoriesAsync();
			return RedirectToAction(nameof(All));
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

		private string GetUserId()
		{
			return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
		}
	}
}
