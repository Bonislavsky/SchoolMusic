using DTO.Students;
using Microsoft.AspNetCore.Mvc;
using SchoolMusic.Application.Students;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("Сreate")]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { error = "name can’t be null or empty" });
            }
            return Ok(await _studentService.CreateStudentHandler(request));
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await _studentService.ReadAllStudentsHandler());
        }
    }
}
