using ChemJourney.Web.ViewModels.PeriodicTable;

namespace ChemJourney.Services.Data.Interfaces
{
    public interface IElementService
    {
        Task<IEnumerable<ElementViewModel>> GetElementsAsync();

        Task<ElementDetailsViewModel?> GetElementByAtomicNumber(int atomicNumber);
    }
}
