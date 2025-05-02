namespace W1417.Models
{
	public class Message
	{
		public int Id { get; set; }
		public int SenderId { get; set; } // User ID of the sender
		public int ReceiverId { get; set; } // User ID of the receiver
		public string Content { get; set; }
		public DateTime SentAt { get; set; }
		public bool IsRead { get; set; }

	
	}
}
