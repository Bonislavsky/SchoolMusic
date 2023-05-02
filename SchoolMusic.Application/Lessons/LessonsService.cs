using DTO.Lessons;
using SchoolMusic.DAL.Database;
using SchoolMusic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Application.Lessons
{
    public class LessonsService
    {
        private readonly SchoolMusicContext _context;

        public LessonsService(SchoolMusicContext contex)
        {
            _context = contex;
        }

        public async Task<long> CreateLessonHandler(CreateLessonRequest request)
        {
            var lesson = new Lesson()
            {
                Date = DateTime.Now,
                Description = request.Description,
                StudentId = request.StudentId,
                TeacherId = request.TeacherId,
            };

            await _context.Lessons.AddAsync(lesson);
            await _context.SaveChangesAsync();

            return lesson.Id;
        }
    }
}
