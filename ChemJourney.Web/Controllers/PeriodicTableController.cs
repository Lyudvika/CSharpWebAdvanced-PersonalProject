using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    public class PeriodicTableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ElementDetails(int atomicNumber)
        {
            return View();
        }
    }
}
