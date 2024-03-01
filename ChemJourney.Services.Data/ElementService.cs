using ChemJourney.Data.Models;
using ChemJourney.Services.Data.Interfaces;
using ChemJourney.Web.Data;
using ChemJourney.Web.ViewModels.PeriodicTable;
using Microsoft.EntityFrameworkCore;

namespace ChemJourney.Services.Data
{
    public class ElementService : IElementService
    {
        private readonly ChemJourneyDbContext dbContext;

        public ElementService(ChemJourneyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ElementViewModel>> GetElementsAsync()
        {
            IEnumerable<ElementViewModel> elements = await this.dbContext
                .Elements
                .Select(e => new ElementViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Symbol = e.Symbol,
                }).ToArrayAsync();

            return elements;
        }
    }
}
