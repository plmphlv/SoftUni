namespace SeminarHub.Data
{
	public static class DataConstants
	{
		public const int TopicMaxLenght = 100;
		public const int TopicMinLenght = 3;

		public const int LecturerNameMaxLenght = 60;
		public const int LecturerNameMinLenght = 5;

		public const int DetailsMaxLenght = 500;
		public const int DetailsMinLenght = 10;

		public const int DurationMaxLenght = 80;
		public const int DurationMinLenght = 30;

		public const int CategoryNameMaxLenght = 50;
		public const int CategoryNameMinLenght = 3;

		public const string DateRequiredFormat = "dd/MM/yyyy HH:mm";

		public const string RequiredFieldErrorMessage = "This field {0} is required!";
		public const string StringLengthErrorMessage = "The field {0} must be between {2} and {1} characters long";
		public const string SeminarDurationErrorMessage = "Seminar must be between {0} and {1} minutes long!";

	}
}
