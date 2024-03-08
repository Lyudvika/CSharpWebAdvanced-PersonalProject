using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.MessageConstants;
using static ChemJourney.Common.EntityValidationConstants.PostReply;

namespace ChemJourney.Web.ViewModels.Reply
{
    public class PostReplyFormViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength, ErrorMessage = LengthMessage)]
        public string Content { get; set; } = string.Empty;

        public string AuthorId { get; set; } = string.Empty;

        public string AuthorName { get; set; } = string.Empty;

        public DateTime ReplyCreated { get; set; }

        public int PostId { get; set; }
    }
}
