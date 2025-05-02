using System.Security.Claims;

namespace W1417.Models
{
	public class Teacher
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Subject { get; set; }
		public List<Class> Classes { get; set; }=new List<Class>();

		
	}
}
