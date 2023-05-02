using DTO.Students;
using DTO.Teachers;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.DAL.Database;
using SchoolMusic.Domain;

namespace SchoolMusic.Application.Teachers
{
    public class TeacherService
    {
        private readonly SchoolMusicContext _context;

        public TeacherService(SchoolMusicContext contex)
        {
            _context = contex;
        }

        public async Task<int> CreateTeacherHandler(CreateTeacherRequest request)
        {
            var teacher = new Teacher()
            {
                Name = request.Name
            };

            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();

            return teacher.Id;
        }

        public async Task<IEnumerable<ReadTeacherReponseDTO>> ReadAllTeachersHandler()
        {
            var teachers = _context.Teachers
                .AsNoTracking()
                .Select(student => new ReadTeacherReponseDTO
                {
                    Id = student.Id,
                    Name = student.Name,
                });

            return teachers;
        }
    }
}
