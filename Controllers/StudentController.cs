using Microsoft.AspNetCore.Mvc;
using StudentDatabase.Models;
using StudentDatabase.Services.Students;

namespace StudentDatabase.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route("FetchStudents")]
    public List<Student> ReadStudents() {
        return _studentService.ReadStudents();
    }

    [HttpPost]
    [Route("CreateStudent/{firstName}/{lastName}/{hobby}")]
    public List<Student> CreateStudent(string firstName, string lastName, string hobby)
    {
        return _studentService.CreateStudent(firstName, lastName, hobby);
    }

    [HttpDelete]
    [Route("DeleteStudent/{firstName}")]
    public List<Student> DeleteStudent(string firstName)
    {
        return _studentService.DeleteStudent(firstName);
    }
}