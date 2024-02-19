using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarHub.Data.Models
{
	public class Seminar
	{
		public Seminar(string topic, string lecturer, string details, string organizerId, DateTime dateAndTime, int duration, int categoryId)
		{
			Topic = topic;
			Lecturer = lecturer;
			Details = details;
			OrganizerId = organizerId;
			DateAndTime = dateAndTime;
			Duration = duration;
			CategoryId = categoryId;
		}

		[Key]
        [Comment("Primay Key")]
        public int Id { get; set; }

		[Required]
		[MaxLength(DataConstants.TopicMaxLenght)]
		public string Topic { get; set; } = string.Empty;

		[Required]
		[MaxLength(DataConstants.TopicMaxLenght)]
        [Comment("A string representing the name of the person giving the lecture")]
        public string Lecturer { get; set; } = string.Empty;

		[Required]
		[MaxLength(DataConstants.TopicMaxLenght)]
        [Comment("Seminar desscription")]
        public string Details { get; set; } = string.Empty;

		[Required]
		public string OrganizerId { get; set; } = string.Empty;

		[Required]
		[ForeignKey(nameof(OrganizerId))]
        [Comment("Seminar Organizer")]
        public IdentityUser Organizer { get; set; } = null!;

		[Required]
        [Comment("Seminar Date and Time")]
        public DateTime DateAndTime { get; set; }

		[Range(DataConstants.DurationMinLenght, DataConstants.DurationMaxLenght)]
        [Comment("Seminar time")]
        public int Duration { get; set; }

		[Required]
		public int CategoryId { get; set; }

		[Required]
		[ForeignKey(nameof(CategoryId))]
        [Comment("Seminar category")]
        public Category Category { get; set; } = null!;

		[Category("A collection of users going to the seminar")]
		public ICollection<SeminarParticipant> SeminarsParticipants { get; set; } = new List<SeminarParticipant>();
	}
}
