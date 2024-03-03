using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.EntityValidationConstants.PostReply;

namespace ChemJourney.Data.Models
{
    [Comment("Replies that are given to a post.")]
    public class PostReply
    {
        [Key]
        [Comment("Id of the post reply.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        [Comment("Content of the reply.")]
        public string Content { get; set; } = string.Empty;

        [Required]
        [Comment("Time when the reply is given.")]
        public DateTime DateTime { get; set; }

        [Required]
        [Comment("User Id of the person who gave the reply.")]
        public Guid ReplierId { get; set; }

        [Comment("User who gave the reply.")]
        public ApplicationUser Replier { get; set; } = null!;
    }
}
