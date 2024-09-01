using ExamManagementApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamManagementApp.DataAccessLayer;

public class AppDbContext : DbContext
{
   
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Student> Students { get; set; }

    public DbSet<Lesson> Lessons { get; set; }

    public DbSet<Exam> Exams { get; set; }

}
