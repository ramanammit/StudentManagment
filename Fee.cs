using W1417.Models;

namespace W1417
{
	public class Fee
	{
		public int Id { get; set; } // Unique identifier for the fee record
		public int StudentId { get; set; } // Foreign key to the Student
		public decimal Amount { get; set; } // Amount of the fee
		public DateTime DueDate { get; set; } // Due date for the fee payment
		public bool IsPaid { get; set; } // Indicates if the fee has been paid
		public DateTime? PaidDate { get; set; } // Date when the fee was paid (nullable)
		public string PaymentMethod { get; set; } // Method of payment (e.g., Cash, Credit Card, etc.)

		// Navigation property to the Student
		public Student Student { get; set; }
	}
}