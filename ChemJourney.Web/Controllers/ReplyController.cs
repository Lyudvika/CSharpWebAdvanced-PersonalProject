using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Extensions;
using ChemJourney.Web.ViewModels.Reply;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
        private readonly IReplyService replyService;
        private readonly IUserService userService;

        public ReplyController(IReplyService replyService, IUserService userService)
        {
            this.replyService = replyService;
            this.userService = userService;
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

            var userId = User.Id();

            try
            {
                await replyService.AddReplyAsync(model, userId,  id);

                return RedirectToAction("Details", "Post", new { id });
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Error! Failed to add the reply.");

                return View(model);
            }
        }

        public async Task<IActionResult> Edit(int id)
        {
            bool replyExists = await replyService.ExistsByIdAsync(id);

            if (!replyExists)
            {
                return RedirectToAction("All", "Post");
            }

            string userId = User.Id();
            bool isUserTheOwner = await userService.IsUserOwnerOfPostReplyById(userId, id);

            if (!isUserTheOwner)
            {
                return RedirectToAction("All", "Post");
            }

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

            bool replyExists = await replyService.ExistsByIdAsync(id);

            if (!replyExists)
            {
                return RedirectToAction("All", "Post");
            }

            string userId = User.Id();
            bool isUserTheOwner = await userService.IsUserOwnerOfPostReplyById(userId, id);

            if (!isUserTheOwner)
            {
                return RedirectToAction("All", "Post");
            }

            try
            {
                await replyService.EditReplyAsync(postModel, id);

                id = await replyService.GetPostId(id);

                return RedirectToAction("Details", "Post", new { id });
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Error! Reply failed editing.");

                return View(postModel);
            }
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
    }
}
