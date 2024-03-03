using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.EntityValidationConstants.ChemicalGroupBlock;

namespace ChemJourney.Data.Models
{

    [Comment("The types of chemical group blocks that exist in the periodic table.")]
    public class ChemicalGroupBlock
    {
        public ChemicalGroupBlock()
        {
            Elements = new HashSet<Element>();
        }

        [Key]
        [Comment("The ID of the chemical group block.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("The Name of the chemical group block.")]
        public string Name { get; set; } = string.Empty;

        [Comment("Colletion of the elements.")]
        public virtual ICollection<Element> Elements { get; set; }
    }
}
