using ChemJourney.Services.Data.Interfaces;
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

        public QuizController(IQuizService quizService, ICategoryService categoryService)
        {
            this.quizService = quizService;
            this.categoryService = categoryService;
        }

        [AllowAnonymous]
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
                QuizViewModel viewModel = await quizService.GetQuizById(id);

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
            int score = await quizService.CalculateQuizScore(id, selectedOptions);

            return RedirectToAction("QuizResults", new { id, score });
        }

        [HttpGet]
        public async Task<IActionResult> QuizResults(int id, int score)
        {
            var quiz = await quizService.GetQuizById(id);

            if (quiz == null)
            {
                return NotFound();
            }

            var viewModel = new QuizResultsViewModel
            {
                Id = id,
                Score = score,
                Title = quiz.Title,
                Description = quiz.Description
            };

            return View(viewModel);
        }
    }
}
