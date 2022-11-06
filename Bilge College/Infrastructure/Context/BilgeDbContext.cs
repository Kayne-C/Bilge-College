using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Bilge_College.Infrastructure.Context
{
    public class BilgeDbContext : DbContext
    {
        public BilgeDbContext(DbContextOptions<BilgeDbContext> options) : base(options)
        {
        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolReport> SchoolReports { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubSubject> SubSubjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
