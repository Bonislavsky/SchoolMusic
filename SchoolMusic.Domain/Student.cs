namespace SchoolMusic.Domain
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Lesson> Lessons { get;set; } = new List<Lesson>();
    }
}
