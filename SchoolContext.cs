using Microsoft.EntityFrameworkCore;

namespace StudentCodeFirst
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite database stored as student.db in project folder
            optionsBuilder.UseSqlite("Data Source=student.db");
        }
    }
}
