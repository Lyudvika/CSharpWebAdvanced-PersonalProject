using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.EntityValidationConstants.Post;

namespace ChemJourney.Data.Models
{

    [Comment("A post that an user can submit to the forum.")]
    public class Post
    {
        public Post()
        {
            PostReplies = new HashSet<PostReply>();
        }

        [Key]
        [Comment("Id of the post.")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Title of the post.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(ContentMaxLength)]
        [Comment("Content of the post.")]
        public string Content { get; set; } = string.Empty;

        [Required]
        [Comment("Category ID of the post.")]
        public int CategoryId { get; set; }

        [Required]
        [Comment("Category of the post.")]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Time when the post has been posted.")]
        public DateTime DateTime { get; set; }

        [Required]
        [Comment("Id of the user who wrote the post.")]
        public Guid AuthorId {  get; set; }

        [Required]
        [Comment("User who wrote the post.")]
        public ApplicationUser Author { get; set; } = null!;

        [Required]
        [Comment("To check if post is deleted.")]
        public bool IsDeleted { get; set; }

        [Comment("Replies given to the post.")]
        public virtual ICollection<PostReply> PostReplies { get; set; }
    }
}
