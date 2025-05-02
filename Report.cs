namespace W1417.Models
{
	public class Report
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public string ReportType { get; set; } // e.g., Attendance, Grades
		public DateTime GeneratedAt { get; set; }
		public string FilePath { get; set; }
	}
}
