using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bilge_College.Infrastructure.Context
{
    public class BilgeDbContext : DbContext
    {
        public BilgeDbContext(DbContextOptions<BilgeDbContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ParentMessage> ParentMessages { get; set; }
        public DbSet<ParentNotice> ParentNotices { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolReport> SchoolReports { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentMessage> StudentMessages { get; set; }
        public DbSet<StudentNotice> StudentNotices { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubSubject> SubSubjects { get; set; }
        public DbSet<SubSubjectClassroom> SubSubjectClassrooms { get; set; }
        public DbSet<SubSubjectTeacher> SubSubjectTeachers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherClassroom> TeacherClassrooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
