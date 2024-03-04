namespace ChemJourney.Web.ViewModels.Post
{
	public class PostDetailsViewModel
    {
        public PostDetailsViewModel()
        {
            PostReplies = new HashSet<PostReplyViewModel>();
        }

        public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Content { get; set; } = string.Empty;
		public string Category { get; set; } = string.Empty;
		public string AuthorId { get; set; } = string.Empty;
		public string AuthorName { get; set; } = string.Empty;
		public DateTime PostCreated { get; set; }

		public IEnumerable<PostReplyViewModel> PostReplies { get; set; }
	}
}
