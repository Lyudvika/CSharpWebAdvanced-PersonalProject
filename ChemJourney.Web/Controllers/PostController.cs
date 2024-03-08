using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.ViewModels.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ChemJourney.Web.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService postService;

		public PostController(IPostService postService)
        {
            this.postService = postService;
		}

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<PostAllViewModel> viewModel = await postService.GetPostsAsync();
            return View(viewModel);
        }

        [AllowAnonymous]
        public async Task<IActionResult> AllByCategory(string category)
        {
			IEnumerable<PostAllViewModel> viewModel = await postService.GetPostsByCategoryAsync(category);
			return View(viewModel);
		}

        [AllowAnonymous]
		public async Task<IActionResult> Details(int id)
		{
			PostDetailsViewModel viewModel = await postService.GetPostById(id);

			if (viewModel == null)
			{
				return NotFound();
			}

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

        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                PostFormViewModel postModel =
                    await this.postService.GetForEditOrDeleteByIdAsync(id);
                postModel.Categories = await postService.GetCategoriesAsync();

                return View(postModel);
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(All));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostFormViewModel postModel, int id)
        {
            if (!ModelState.IsValid)
            {
                postModel.Categories = await postService.GetCategoriesAsync();

                return View(postModel);
            }

            try
            {
                await postService.EditPostAsync(postModel, id);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Error! Post failed editing.");

                return View(postModel);
            }

			return RedirectToAction(nameof(Details), new { id });
		}

		public async Task<IActionResult> Delete(int id)
		{
            try
            {
                await postService.DeletePostAsync(id);
            }
            catch (Exception)
            {

            }

            return RedirectToAction(nameof(All));
        }

		private string GetUserId()
		{
			return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
		}
	}
}
