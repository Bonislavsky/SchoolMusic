namespace SchoolMusic.Domain
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
