using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.EntityValidationConstants.Quiz;

namespace ChemJourney.Data.Models
{
    [Comment("Questions that a quiz will contain.")]
    public class QuizQuestion
    {
        [Key]
        [Comment("Id of the question.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("The question given.")]
        public string QuestionText { get; set; } = string.Empty;

        [Required]
        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("First option for the quiz question.")]
        public string OptionOne { get; set; } = string.Empty;

        [Required]
        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("Second option for the quiz question.")]
        public string OptionTwo { get; set; } = string.Empty;

        [Required]
        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("Third option for the quiz question.")]
        public string OptionThree { get; set; } = string.Empty;

        [Required]
        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("Fourth option for the quiz question.")]
        public string OptionFour { get; set; } = string.Empty;

        [Required]
        [MaxLength(DefaultAllowedMaxLength)]
        [Comment("Correct answer to the question,")]
        public string CorrectOption { get; set; } = string.Empty;

        [Required]
        [Comment("Quiz ID to which the question is associated with.")]
        public int QuizId { get; set; }

        [Required]
        [Comment("Quiz to which the question is associated with.")]
        public Quiz Quiz { get; set; } = null!;
    }
}
