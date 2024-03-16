namespace ChemJourney.Web.ViewModels.Quiz
{
    public class QuizViewModel
    {
        public QuizViewModel()
        {
            QuizQuestions = new HashSet<QuizQuestionsViewModel>();
        }

        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public IEnumerable<QuizQuestionsViewModel> QuizQuestions { get; set; }
    }
}
