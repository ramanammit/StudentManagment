namespace W1417.Models
{
	public class Timetable
	{
		public int Id { get; set; }
		public int ClassId { get; set; }
		public List<TimetableEntry> Entries { get; set; }
		
	}
}
