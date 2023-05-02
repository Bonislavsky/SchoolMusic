using DTO.Students;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.DAL.Database;
using SchoolMusic.Domain;

namespace SchoolMusic.Application.Students
{
    public class StudentService
    {
        private readonly SchoolMusicContext _context;

        public StudentService(SchoolMusicContext contex)
        {
            _context = contex;
        }

        public async Task<int> CreateStudentHandler(CreateStudentRequest request)
        {
            var student = new Student()
            {
                Name = request.Name
            };

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            return student.Id;
        }

        public async Task<IEnumerable<ReadStudentReponseDTO>> ReadAllStudentsHandler()
        {
            var students = _context.Students
                .AsNoTracking()
                .Select(student => new ReadStudentReponseDTO
                {
                    Id = student.Id,
                    Name = student.Name,
                });

            return students;
        }
    }
}
