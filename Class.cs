namespace W1417.Models
{
	public class Class
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public List<Student> Students { get; set; }
		public List<LessonPlan> LessonPlans { get; set; }

		
	}
}