namespace DTO.Lessons
{
    public class CreateLessonRequest
    { 
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int StudentId { get; set; }

        public int TeacherId { get; set; }
    }
}
