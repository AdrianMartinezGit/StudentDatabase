using StudentDatabase.Models;

namespace StudentDatabase.Services.Students;

public interface IStudentService
{
    public List<Student> ReadStudents();
    public List<Student> CreateStudent(string firstName, string lastName, string hobby);
    public List<Student> DeleteStudent(string firstName);
}