using W1417.Models;

namespace W1417.Repositary
{
	public interface IStudent
	{
		List<Student> GetAll();
		Student GetById(int id);
		void Add(Student student);
		void Update(Student student);
		void Delete(int id);
	}
}
