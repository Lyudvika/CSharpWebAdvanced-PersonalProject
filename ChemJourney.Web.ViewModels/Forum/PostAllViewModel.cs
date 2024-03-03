using static ChemJourney.Common.EntityValidationConstants.DateTimeFormat;

namespace ChemJourney.Web.ViewModels.Forum
{
    public class PostAllViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string DateTime { get; set; } = string.Empty;

        public string Writer { get; set; } = string.Empty;
    }
}
