namespace W1417.Models
{
	public class LessonPlan
	{
		public int Id { get; set; }
		public int ClassId { get; set; }
		public string Topic { get; set; }
		public DateTime Date { get; set; }
		public string Content { get; set; }

	}
}