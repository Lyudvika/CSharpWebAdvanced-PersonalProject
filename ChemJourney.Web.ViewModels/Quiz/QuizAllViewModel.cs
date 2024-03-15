namespace ChemJourney.Web.ViewModels.Quiz
{
    public class QuizAllViewModel
    {
        public int Id {  get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public string Category { get; set; } = string.Empty;
    }
}
