using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ChemJourney.Data.Models
{
    [Comment("The elements of the Periodic Table")]
    public class Element
    {
        [Key]
        [Comment("The atomic number of the element")]
        public int Id { get; set; }

        [Required]
        [Comment("The number of the element")]
        public string Name { get; set; } = string.Empty;

        [Required]
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
        [Comment("The standard state of the element")]
        public string StandardState { get; set; } = string.Empty;

        public int ChemicalGroupBlockId { get; set; }

        [Comment("The chemical group block of the element")]
        public ChemicalGroupBlock ChemicalGroupBlock { get; set; } = null!;

        [Required]
        [Comment("The standart state of the element")]
        public string OxidationStates { get; set; } = string.Empty;
    }
}
