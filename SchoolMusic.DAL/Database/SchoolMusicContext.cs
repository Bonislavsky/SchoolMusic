using Microsoft.EntityFrameworkCore;
using SchoolMusic.Domain;

namespace SchoolMusic.DAL.Database
{
    public partial class SchoolMusicContext : DbContext
    {
        public SchoolMusicContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
