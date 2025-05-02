using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using W1417.Models;
using W1417.Repositary;

namespace W1417.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TeacherController : ControllerBase
	{

		private readonly ITeacher _teacherRepository;

		public TeacherController(ITeacher teacherRepository)
		{
			_teacherRepository = teacherRepository;
		}

		[HttpGet("GetAllTeacherList")]
		public IActionResult GetAllTeacherList()
		{
			var teachers = _teacherRepository.GetAllTeachers();
			return Ok(teachers);
		}

		[HttpPost("AddTeacher")]
		public IActionResult AddTeacher(Teacher teacher)
		{
			_teacherRepository.Add(teacher);
			return Ok("Save Succesfully !");
		}

		[HttpPost("UpdateTeacher")]
		public IActionResult UpdateTeacher(Teacher teacher)
		{
			 _teacherRepository.Update(teacher);
			return Ok("Update Succesfully !");
		}

		[HttpPost("DeleteTeacher")]
		public IActionResult DeleteTeacher(int  id)
		{
		 _teacherRepository.Delete(id);
			return Ok("Delete Succesfully !");
		}

		[HttpGet("GetTeacherById")]
		public IActionResult GetTeacherById(int id)
		{
			var teachers = _teacherRepository.GetTeacherById(id);
			return Ok(teachers);
		}
	}
}
