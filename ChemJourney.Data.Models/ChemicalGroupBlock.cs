using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemJourney.Data.Models
{
    public class ChemicalGroupBlock
    {
        public ChemicalGroupBlock()
        {
            Elements = new HashSet<Element>();
        }

        [Key]
        [Comment("The ID of the chemical group block.")]
        public int Id { get; set; }

        [Comment("The Name of the chemical group block.")]
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Element> Elements { get; set; }
    }
}
