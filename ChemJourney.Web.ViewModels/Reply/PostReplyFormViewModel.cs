namespace ChemJourney.Web.ViewModels.Reply
{
    public class PostReplyFormViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; } = string.Empty;

        public string AuthorId { get; set; } = string.Empty;

        public string AuthorName { get; set; } = string.Empty;

        public DateTime ReplyCreated { get; set; }

        public int PostId { get; set; }

        public string PostTitle { get; set; } = string.Empty;

        public string PostContent { get; set; } = string.Empty;
    }
}
