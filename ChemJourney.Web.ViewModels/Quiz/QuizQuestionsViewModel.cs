namespace ChemJourney.Web.ViewModels.Quiz
{
    public class QuizQuestionsViewModel
    {
        public int Id { get; set; }

        public string QuestionText { get; set; } = string.Empty;

        public List<string> Options { get; set; } = new List<string>();

        public int QuizId { get; set; }
    }
}
