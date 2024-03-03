using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.ViewModels.Forum;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    public class ForumController : Controller
    {
        private readonly IPostService postService;

        public ForumController(IPostService postService)
        {
            this.postService = postService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<PostAllViewModel> viewModel = await this.postService.GetPostsAsync();
            return View(viewModel);
        }
    }
}
