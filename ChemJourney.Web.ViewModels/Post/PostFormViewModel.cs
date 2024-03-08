using System.ComponentModel.DataAnnotations;
using static ChemJourney.Common.MessageConstants;
using static ChemJourney.Common.EntityValidationConstants.Post;

namespace ChemJourney.Web.ViewModels.Post
{
	public class PostFormViewModel
    {
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength, ErrorMessage = LengthMessage)]
        public string Content { get; set; } = string.Empty;

		public string AuthorId { get; set; } = string.Empty;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
	}
}
