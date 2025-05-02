namespace W1417.Models
{
	public class Exam
	{
		public int Id { get; set; }
		public int ClassId { get; set; }
		public string Subject { get; set; }
		public DateTime ExamDate { get; set; }
		public List<ExamResult> Results { get; set; }

	}
}
