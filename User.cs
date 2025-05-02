using System;
using System.Security.Cryptography;
using System.Text;

namespace W1417.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string PasswordHash { get; set; } // Store hashed passwords
		public UserRole Role { get; set; }
		public string? Email { get; set; }
		public DateTime CreatedAt { get; set; }
		
		
	}

	public class Login
	{
		public string Password { get; set; } // Store hashed passwords
		
		public string? Email { get; set; }
	}


	public enum UserRole
	{
		Admin,
		Teacher,
		Student,
		Parent
	}

	
}

