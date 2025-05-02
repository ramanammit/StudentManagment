namespace W1417.Models
{
	public class ClassEnrollment
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public int ClassId { get; set; }
		public DateTime EnrollmentDate { get; set; }
		public List<Attendance> Attendances { get; set; }

	
	}
}