using DTO.Teachers;
using Microsoft.AspNetCore.Mvc;
using SchoolMusic.Application.Students;
using SchoolMusic.Application.Teachers;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherService _teacherService;

        public TeacherController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost("Сreate")]
        public async Task<IActionResult> CreateTeacher([FromBody] CreateTeacherRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { error = "name can’t be null or empty" });
            }
            return Ok(await _teacherService.CreateTeacherHandler(request));
        }

        [HttpGet]
        public async Task<IActionResult> GetTeachers()
        {
            return Ok(await _teacherService.ReadAllTeachersHandler());
        }
    }
}
