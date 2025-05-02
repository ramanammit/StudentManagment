namespace W1417.Models
{
	public class Attendance
	{
		public int Id { get; set; }
		public int ClassEnrollmentId { get; set; }
		public DateTime Date { get; set; }
		public bool IsPresent { get; set; }

	}
}