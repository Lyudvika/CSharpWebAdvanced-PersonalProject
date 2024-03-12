using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Extensions;
using ChemJourney.Web.ViewModels.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;
        private readonly IUserService userService;

        public PostController(IPostService postService, ICategoryService categoryService, IUserService userService)
        {
            this.postService = postService;
            this.categoryService = categoryService;
            this.userService = userService;
		}

        [AllowAnonymous]
        public async Task<IActionResult> All(string searchString)
        {
            IEnumerable<PostAllViewModel> model = await postService.GetPostsAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(p => p.Title.ToLower().Contains(searchString.ToLower()) || 
                p.Content.ToLower().Contains(searchString.ToLower())).ToList();
            }

            return View(model);
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
            bool postExists = await postService.ExistsByIdAsync(id);

            if (!postExists)
            {
                return RedirectToAction(nameof(All));
            }

            try
            {
                PostDetailsViewModel viewModel = await postService.GetPostById(id);

                return View(viewModel);
            }
            catch(Exception)
            {

                return RedirectToAction(nameof(All));
            }
		}

        [HttpGet]
		public async Task<IActionResult> Create()
		{
            var model = new PostFormViewModel
            {
                Categories = await categoryService.GetCategoriesAsync()
            };

            return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Create(PostFormViewModel model)
		{
            bool categoryExists = await categoryService.ExistsByIdAsync(model.CategoryId);

            if (!categoryExists)
                ModelState.AddModelError(nameof(model.CategoryId), "Selected category doesn't exist!");

            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.GetCategoriesAsync();

                return View(model);
            }

            var userId = User.Id();

            try
			{
				await postService.AddPostAsync(model, userId);
			}
			catch (Exception)
			{
				ModelState.AddModelError(string.Empty, "Error! Failed to add the post.");

				return View(model);
			}

			model.Categories = await categoryService.GetCategoriesAsync();
			return RedirectToAction(nameof(All));
		}

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            bool postExists = await postService.ExistsByIdAsync(id);

            if (!postExists)
            {
                return RedirectToAction(nameof(All));
            }

            string userId = User.Id();
            bool isUserTheOwner = await userService.IsUserOwnerOfPostById(userId, id);

            if (!isUserTheOwner)
            {
                return RedirectToAction(nameof(All));
            }

            try
            {
                PostFormViewModel postModel =
                    await this.postService.GetForEditOrDeleteByIdAsync(id);
                postModel.Categories = await categoryService.GetCategoriesAsync();

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
                postModel.Categories = await categoryService.GetCategoriesAsync();

                return View(postModel);
            }

            bool postExists = await postService.ExistsByIdAsync(id);

            if (!postExists)
            {
                return RedirectToAction(nameof(All));
            }

            string userId = User.Id();
            bool isUserTheOwner = await userService.IsUserOwnerOfPostById(userId, id);

            if (!isUserTheOwner)
            {
                return RedirectToAction(nameof(All));
            }

            try
            {
                await postService.EditPostAsync(postModel, id);

                return RedirectToAction(nameof(Details), new { id });
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Error! Post failed editing.");

                return View(postModel);
            }
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
	}
}
