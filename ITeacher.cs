using W1417.Models;

namespace W1417.Repositary
{
	public interface ITeacher
	{
		List<Teacher> GetAllTeachers();
		Teacher GetTeacherById(int id);
		void Add(Teacher teacher);
		void Update(Teacher teacher);
		void Delete(int id);
	}
}
