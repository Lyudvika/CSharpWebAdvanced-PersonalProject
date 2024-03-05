namespace ChemJourney.Web.ViewModels.Post
{
	public class PostFormViewModel
    {
        public string Title { get; set; } = string.Empty;

		public string Content { get; set; } = string.Empty;

		public string Author { get; set; } = string.Empty;

		public string AuthorId { get; set; } = string.Empty;

		public DateTime PostCreated { get; set; }

		public int CategoryId { get; set; }

		public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
	}
}
