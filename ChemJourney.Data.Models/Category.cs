using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.EntityValidationConstants.Category;

namespace ChemJourney.Data.Models
{
    [Comment("Categories that a post might have.")]
    public class Category
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        [Comment("Id of the category")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the category")]
        public string Name { get; set; } = string.Empty;

        [Comment("Posts collection")]
        public ICollection<Post> Posts { get; set; }
    }
}
