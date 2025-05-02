namespace W1417.Models
{
	public class Assignment
	{
		public int Id { get; set; }
		public int ClassId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DueDate { get; set; }
		public List<Submission> Submissions { get; set; }

	}
}
