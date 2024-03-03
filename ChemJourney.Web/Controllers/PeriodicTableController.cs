using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.ViewModels.PeriodicTable;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    public class PeriodicTableController : Controller
    {
        private readonly IElementService elementService;

        public PeriodicTableController(IElementService elementService)
        {
            this.elementService = elementService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<ElementViewModel> viewModel = await this.elementService.GetElementsAsync();
            return View(viewModel);
        }

        public async Task<ActionResult> ElementDetails(int atomicNumber)
        {
            ElementDetailsViewModel? element = await this.elementService.GetElementByAtomicNumber(atomicNumber);

			if (element == null)
			{
				return NotFound();
			}

			return View(element);
        }
    }
}
