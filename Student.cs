namespace W1417.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public string ImageUrl { get; set; }
		public List<AcademicHistory> AcademicHistories { get; set; } = new List<AcademicHistory>();
		public List<ClassEnrollment> ClassEnrollments { get; set; } = new List<ClassEnrollment>();

		public List<Class> Classes { get; set; } = new List<Class>();

		public List<Parent> Parents { get; set; } = new List<Parent>();
		// Navigation Property for Parent
		public int? ParentId { get; set; } = null;

		

	}
}
