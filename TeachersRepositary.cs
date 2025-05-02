using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using W1417.Models;

namespace W1417.Repositary
{
	public class TeachersRepositary:ITeacher
	{
		private readonly SchoolDbContext _context;

		public TeachersRepositary(SchoolDbContext context)
		{
			_context=context;
		}
		public List<Teacher> GetAllTeachers()
		{
			return _context.Teachers.ToList();
		}

		public void Add(Teacher teacher)
		{
			try
			{
				_context.Teachers.Add(teacher);
				_context.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception("Error in Saving Data");
			}
		}
		public void Update(Teacher teacher)
		{
			_context.Teachers.Update(teacher);
			_context.SaveChanges();
		}

		
		public void Delete(int id)
		{
			var delid=_context.Teachers.Find(id);
			_context.Teachers.Remove(delid);
			_context.SaveChanges();
		}

		public Teacher GetTeacherById(int id)
		{
			return _context.Teachers.Find(id);
		}
	}
}
