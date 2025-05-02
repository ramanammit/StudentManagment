using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using W1417.Models;

namespace W1417.Repositary
{
	public class StudentRepository : IStudent
	{
		private readonly SchoolDbContext _context;

		public StudentRepository(SchoolDbContext context)
		{
			_context = context;
		}

		public List<Student> GetAll()
		{
			return _context.Students.ToList();
		}

		public Student GetById(int id)
		{
			return _context.Students.Find(id);
		}

		public void Add(Student student)
		{
			_context.Students.Add(student);
			_context.SaveChanges();
		}

		public void Update(Student student)
		{
			_context.Students.Update(student);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var student = _context.Students.Find(id);
			if (student != null)
			{
				_context.Students.Remove(student);
				_context.SaveChanges();
			}
		}
	}
}
