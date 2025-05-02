using Microsoft.EntityFrameworkCore;
using W1417.Models;

namespace W1417
{
	public class SchoolDbContext : DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
		{
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Parent> Parents { get; set; }
		public DbSet<Class> Classes { get; set; }
		public DbSet<Attendance> Attendances { get; set; }
		public DbSet<Assignment> Assignments { get; set; }
		public DbSet<Submission> Submissions { get; set; }
		public DbSet<Exam> Exams { get; set; }
		public DbSet<ExamResult> ExamResults { get; set; }
		public DbSet<Fee> Fees { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<Timetable> Timetables { get; set; }
		public DbSet<TimetableEntry> TimetableEntries { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Announcement> Announcements { get; set; }
		public DbSet<AcademicHistory> AcademicHistories { get; set; }
		public DbSet<ClassEnrollment> ClassEnrollments { get; set; }
		public DbSet<LessonPlan> LessonPlans { get; set; }
		public DbSet<Report> Reports { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<Translation> Translations { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure relationships and constraints here

			modelBuilder.Entity<User>()
				.HasIndex(u => u.Username)
				.IsUnique();

			modelBuilder.Entity<Student>()
				.HasMany(s => s.AcademicHistories)
				.WithOne()
				.HasForeignKey(ah => ah.StudentId);

			modelBuilder.Entity<Student>()
				.HasMany(s => s.ClassEnrollments)
				.WithOne()
				.HasForeignKey(ce => ce.StudentId);
			modelBuilder.Entity<Student>()
				.HasMany(s => s.Parents)
				.WithOne()
				.HasForeignKey(ce => ce.Id);

			modelBuilder.Entity<ClassEnrollment>()
							.HasMany(ce => ce.Attendances)
							.WithOne()
							.HasForeignKey(a => a.ClassEnrollmentId);

			modelBuilder.Entity<Class>()
				.HasMany(c => c.Students)
				.WithMany(s => s.Classes)
				.UsingEntity<ClassEnrollment>();

			modelBuilder.Entity<Fee>()
				.HasOne(f => f.Student)
				.WithMany()
				.HasForeignKey(f => f.StudentId);

			modelBuilder.Entity<Assignment>()
				.HasMany(a => a.Submissions)
				.WithOne()
				.HasForeignKey(s => s.AssignmentId);

			modelBuilder.Entity<Exam>()
				.HasMany(e => e.Results)
				.WithOne()
				.HasForeignKey(r => r.ExamId);
		}
	}
}
