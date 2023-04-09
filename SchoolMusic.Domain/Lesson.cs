namespace SchoolMusic.Domain
{
    public class Lesson
    {
        public long id { get; set; }
       
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
