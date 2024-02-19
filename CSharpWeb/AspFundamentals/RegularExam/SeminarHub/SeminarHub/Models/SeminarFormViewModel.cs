using SeminarHub.Data;
using System.ComponentModel.DataAnnotations;

namespace SeminarHub.Models
{
	public class SeminarFormViewModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = DataConstants.RequiredFieldErrorMessage)]
		[StringLength(DataConstants.TopicMaxLenght, MinimumLength = DataConstants.TopicMinLenght, ErrorMessage = DataConstants.StringLengthErrorMessage)]
		public string Topic { get; set; } = string.Empty;

		[Required(ErrorMessage = DataConstants.RequiredFieldErrorMessage)]
		[StringLength(DataConstants.LecturerNameMaxLenght, MinimumLength = DataConstants.LecturerNameMinLenght, ErrorMessage = DataConstants.StringLengthErrorMessage)]
		public string Lecturer { get; set; } = string.Empty;

		[Required(ErrorMessage = DataConstants.RequiredFieldErrorMessage)]
		[StringLength(DataConstants.DetailsMaxLenght, MinimumLength = DataConstants.DetailsMinLenght, ErrorMessage = DataConstants.StringLengthErrorMessage)]
		public string Details { get; set; } = string.Empty;

		[Required(ErrorMessage = DataConstants.RequiredFieldErrorMessage)]
		public string DateAndTime { get; set; } = string.Empty;

		[Range(DataConstants.DurationMinLenght, DataConstants.DurationMaxLenght)]
		public int Duration { get; set; }

		[Required(ErrorMessage = DataConstants.RequiredFieldErrorMessage)]
		public int CategoryId { get; set; }

		public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
	}
}
