using ChemJourney.Services.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChemJourney.Web.Controllers
{
    public class ConverterController : Controller
    {
        private readonly IConverterService converterService;

        public ConverterController(IConverterService converterService)
        {
            this.converterService = converterService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
