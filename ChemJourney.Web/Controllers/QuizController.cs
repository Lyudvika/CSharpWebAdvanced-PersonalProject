using ChemJourney.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    public class QuizController : Controller
    {
        private readonly IQuizService quizService;

        public QuizController(IQuizService quizService)
        {
            this.quizService = quizService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
