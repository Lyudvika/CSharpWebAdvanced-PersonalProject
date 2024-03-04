namespace ChemJourney.Web.ViewModels.Post
{
	public class PostReplyViewModel
	{
		public int Id { get; set; }

		public string Content { get; set; } = string.Empty;

		public string AuthorId { get; set; } = string.Empty;

		public string AuthorName { get; set; } = string.Empty;

		public DateTime ReplyCreated { get; set; }

		public int PostId { get; set; }
	}
}
