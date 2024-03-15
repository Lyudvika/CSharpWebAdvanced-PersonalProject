using ChemJourney.Services.Data;
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
    }
}
