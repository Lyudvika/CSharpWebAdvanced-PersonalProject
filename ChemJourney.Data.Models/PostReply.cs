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
        [Comment("To check if reply is deleted.")]
        public bool IsDeleted { get; set; }

        [Required]
        [Comment("User Id of the person who gave the reply.")]
        public Guid AuthorId { get; set; }

        [Comment("User who gave the reply.")]
        public ApplicationUser Author { get; set; } = null!;

        [Required]
        [Comment("Post ID to which the reply is associated.")]
        public int PostId { get; set; }

        [Comment("Post to which the reply is associated.")]
        public Post Post { get; set; } = null!;
    }
}
