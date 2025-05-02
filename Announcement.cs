namespace W1417.Models
{
	public class Announcement
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime CreatedAt { get; set; }
		public int CreatedById { get; set; } 
		// User ID of the creator (Admin/Teacher)
	}
}
