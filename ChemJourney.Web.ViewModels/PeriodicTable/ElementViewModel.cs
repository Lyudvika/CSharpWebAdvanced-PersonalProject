using System.ComponentModel.DataAnnotations;

namespace ChemJourney.Web.ViewModels.PeriodicTable
{
    public class ElementViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Symbol { get; set; } = string.Empty;
    }
}
