using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.EntityValidationConstants.Quiz;

namespace ChemJourney.Data.Models
{
    [Comment("Quiz that users can solve.")]
    public class Quiz
    {
        public Quiz()
        {
            QuizQuestions = new HashSet<QuizQuestion>();
        }

        [Key]
        [Comment("Id of the quiz.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("Title of the quiz.")]
        public string Title { get; set; } = string.Empty;

        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("Quiz description.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("Category ID of the quiz.")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("Category of the quiz.")]
        public Category Category { get; set; } = null!;

        [Comment("Replies given to the post.")]
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
