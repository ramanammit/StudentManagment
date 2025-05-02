namespace W1417.Models
{
	public class TimetableEntry
	{
		public int Id { get; set; }
		public int TimetableId { get; set; }
		public DayOfWeek Day { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }
		public int ClassId { get; set; }
		public int TeacherId { get; set; }

	
	}
}