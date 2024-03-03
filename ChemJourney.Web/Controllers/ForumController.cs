using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
