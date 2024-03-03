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
                    ChemicalGroupBlockId = e.ChemicalGroupBlockId
                }).ToArrayAsync();

            return elements;
        }

        public async Task<ElementDetailsViewModel> GetElementByAtomicNumber(int atomicNumber)
        {
            ElementDetailsViewModel? element = await this.dbContext
                .Elements
                .Where(e => e.Id == atomicNumber)
                .Select(e => new ElementDetailsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Symbol = e.Symbol,
                    AtomicMass = e.AtomicMass,
                    ChemicalGroupBlockId = e.ChemicalGroupBlockId,
                    MeltingPoint = e.MeltingPoint,
                    BoilingPoint = e.BoilingPoint,
                    StandardState = e.StandardState,
                    OxidationStates = e.OxidationStates,
                    ChemicalGroupBlock = new ChemicalGroupBlockViewModel
                    {
                        Id = e.ChemicalGroupBlock.Id,
                        Name = e.ChemicalGroupBlock.Name,
                    }
                })
                .FirstOrDefaultAsync();

            return element;
        }
    }
}
