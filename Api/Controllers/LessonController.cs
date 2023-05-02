using DTO.Lessons;
using DTO.Students;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Application.Lessons;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonController : ControllerBase
    {
        private readonly LessonsService _lessonService;

        public LessonController(LessonsService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpPost("Сreate")]
        public async Task<IActionResult> CreateLesson([FromBody] CreateLessonRequest request)
        {
            try
            {
                return Ok(await _lessonService.CreateLessonHandler(request));
            }
            catch (DbUpdateException)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { error = "studentId or teacherId not exist" });
            }
        }
    }
}
