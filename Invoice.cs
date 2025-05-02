using W1417.Models;

namespace W1417
{
	public class Invoice
	{
		public int Id { get; set; } // Unique identifier for the invoice
		public int StudentId { get; set; } // Foreign key to the Student
		public decimal TotalAmount { get; set; } // Total amount of the invoice
		public decimal AmountPaid { get; set; } // Amount that has been paid
		public decimal Balance { get; set; } // Remaining balance
		public DateTime IssueDate { get; set; } // Date the invoice was issued
		public DateTime DueDate { get; set; } // Due date for payment
		public bool IsPaid { get; set; } // Indicates if the invoice has been fully paid
		public string PaymentMethod { get; set; } // Method of payment (e.g., Cash, Credit Card, etc.)
		public string Description { get; set; } // Description of the invoice

		// Navigation property to the Student
		public Student Student { get; set; }
	}
}