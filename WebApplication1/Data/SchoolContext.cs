using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Enrolments> Enrolments { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
    }
}