using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using W1417.Models;

namespace W1417.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class StudentController : Controller
	{
		private readonly SchoolDbContext _context;

		public StudentController(SchoolDbContext context)
		{
			_context = context;
		}
		[HttpGet("GetStudent")]
		public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
		{
			var students = await _context.Students.Include(s => s.AcademicHistories).Include(s => s.ClassEnrollments).Include(s => s.Classes) 
								.ToListAsync();
			return Ok(students);
		}

		[HttpPost("AddStudent")]
		public async Task<ActionResult> AddStudent(Student Stu)
		{
			if (Stu == null) return BadRequest("Invalid Student");
			try
			{
				if (Stu.Id != 0)
				{
					_context.Entry(Stu).State = EntityState.Modified;
				}
				else
				{
					_context.Students.Add(Stu);
				}
				_context.SaveChanges();
				return Ok("Saved Sucessfully");
			}
			catch (Exception ex)
			{
				return Ok("Invalid Data");
			}
		}

		[HttpPost("DeleteStudent")]
		public async Task<ActionResult> DeleteStudent(int? id)
		{
			if (id == null) return BadRequest("Error");
			try
			{
				var delId = _context.Students.Find(id);
				_context.Students.Remove(delId);
				_context.SaveChanges();
				return Ok("Delete Succesfully !");
			}
			catch (Exception ex)
			{
				return Ok("Invalid Data");
			}
		}

		[HttpPost("GetStudentById")]
		public async Task<ActionResult> GetStudentById(int? id)
		{
			if (id == null) return BadRequest("Error");
			try
			{
				var student1 = _context.Students.Find(id);
				return Ok(student1);
			}
			catch (Exception ex)
			{
				return Ok("Invalid Data");
			}
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
