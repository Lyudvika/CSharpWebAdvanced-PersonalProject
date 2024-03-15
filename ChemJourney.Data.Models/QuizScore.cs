using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ChemJourney.Data.Models
{
    [Comment("Information about who took which quiz.")]
    public class QuizScore
    {
        [Key]
        [Comment("Id of the user scores")]
        public int Id { get; set; }

        [Required]
        [Comment("ID of the user who took the quiz.")]
        public Guid UserId { get; set; }

        [Required]
        [Comment("User who took the quiz.")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("ID of the quiz.")]
        public int QuizId { get; set; }

        [Required]
        [Comment("The quiz.")]
        public Quiz Quiz { get; set; } = null!;

        [Required]
        [Comment("Score received from the quiz.")]
        public int Score { get; set; }

        [Required]
        [Comment("Date when the quiz was taken.")]
        public DateTime DateCompleted { get; set; }
    }
}
