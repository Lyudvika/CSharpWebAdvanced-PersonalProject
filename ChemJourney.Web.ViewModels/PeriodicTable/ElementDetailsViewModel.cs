namespace ChemJourney.Web.ViewModels.PeriodicTable
{
    public class ElementDetailsViewModel
	{
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Symbol { get; set; } = string.Empty;

        public double AtomicMass { get; set; }

        public double? MeltingPoint { get; set; }

        public double? BoilingPoint { get; set; }

        public string StandardState { get; set; } = string.Empty;

        public string OxidationStates { get; set; } = string.Empty;

        public int ChemicalGroupBlockId { get; set; }

        public ChemicalGroupBlockViewModel ChemicalGroupBlock { get; set; } = null!;
    }
}
