namespace ChemJourney.Web.ViewModels.Post
{
	public class PostAllViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

		public int CategoryId { get; set; }

		public string PostCreated { get; set; } = string.Empty;

        public string AuthorName { get; set; } = string.Empty;

        public int RepliesCount {  get; set; }
    }
}
