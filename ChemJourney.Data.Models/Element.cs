using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static ChemJourney.Common.EntityValidationConstants.Element;

namespace ChemJourney.Data.Models
{
    [Comment("The elements of the Periodic Table")]
    public class Element
    {
        [Key]
        [Comment("The atomic number of the element")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("The number of the element")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(SymbolMaxLength)]
        [Comment("The symbol of the element")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [Comment("The atomic mass of the element")]
        public double AtomicMass { get; set; }

        [Comment("The melting point of the element")]
        public double? MeltingPoint { get; set; }

        [Comment("The boiling point of the element")]
        public double? BoilingPoint { get; set; }

        [Required]
        [MaxLength(StandardStateMaxLength)]
        [Comment("The standard state of the element")]
        public string StandardState { get; set; } = string.Empty;

        [Required]
        public int ChemicalGroupBlockId { get; set; }

        [Required]
        [Comment("The chemical group block of the element")]
        public ChemicalGroupBlock ChemicalGroupBlock { get; set; } = null!;

        [Required]
        [MaxLength(OxidationStatesStateMaxLength)]
        [Comment("The standart state of the element")]
        public string OxidationStates { get; set; } = string.Empty;
    }
}
