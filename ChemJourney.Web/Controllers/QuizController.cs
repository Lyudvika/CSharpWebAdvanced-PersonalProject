using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Extensions;
using ChemJourney.Web.ViewModels.Quiz;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuizService quizService;
        private readonly ICategoryService categoryService;
        private readonly IUserService userService;

        public QuizController(IQuizService quizService, ICategoryService categoryService, IUserService userService)
        {
            this.quizService = quizService;
            this.categoryService = categoryService;
            this.userService = userService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            IEnumerable<QuizAllViewModel> model = await quizService.GetQuizzesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> TakeQuiz(int id)
        {
            bool quizExists = await quizService.ExistsByIdAsync(id);

            if (!quizExists)
            {
                return RedirectToAction(nameof(All));
            }

            try
            {
                QuizViewModel viewModel = await quizService.GetQuizByIdAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(All));
            }
        }

        [HttpPost]
        public async Task<IActionResult> SubmitQuiz(int id, Dictionary<int, string> selectedOptions)
        {
            int score = await quizService.CalculateQuizScoreAsync(id, selectedOptions);

            int quizScore = await quizService.SaveQuizScoreAndReturnIdAsync(User.Id(), id, score);

            return RedirectToAction("QuizResult", new { id = quizScore });
        }

        [HttpGet]
        public async Task<IActionResult> QuizResult(int id)
        {
            string userId = User.Id();

            bool isUserTheOwner = await userService.IsUserOwnerOfQuizScoreByIdAsync(userId, id);

            if (!isUserTheOwner)
            {
                return BadRequest();
            }

            QuizScoreViewModel quizScore = await quizService.GetQuizScoreByIdAsync(id);

            if (quizScore == null)
            {
                return NotFound();
            }

            return View(quizScore);
        }
    }
}
