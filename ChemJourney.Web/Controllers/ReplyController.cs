using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.ViewModels.Reply;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ChemJourney.Web.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IReplyService replyService;

        public ReplyController(IReplyService replyService)
        {
            this.replyService = replyService;
        }

        public IActionResult Create()
        {
            var model = new PostReplyFormViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id, PostReplyFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = GetUserId();

            try
            {
                await replyService.AddReplyAsync(model, userId,  id);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Error! Failed to add the reply.");

                return View(model);
            }

            return RedirectToAction("Details", "Post", new { id });
        }

        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                PostReplyFormViewModel postModel =
                    await replyService.GetForEditOrDeleteByIdAsync(id);

                return View(postModel);
            }
            catch (Exception)
            {
                return RedirectToAction("All", "Post");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostReplyFormViewModel postModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(postModel);
            }

            try
            {
                await replyService.EditReplyAsync(postModel, id);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Error! Reply failed editing.");

                return View(postModel);
            }

            id = await replyService.GetPostId(id);

            return RedirectToAction("Details", "Post", new { id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await replyService.DeleteReplyAsync(id);
            }
            catch (Exception)
            {

            }

            id = await replyService.GetPostId(id);

            return RedirectToAction("Details", "Post", new { id });
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
