using ExamManagementApp.DataAccessLayer;
using ExamManagementApp.Domain.Entities;
using ExamManagementApp.Repositories.Abstracts;

namespace ExamManagementApp.Repositories.Concretes;


public class StudentRepository : Repository<Student>, IStudentRepository
{
    public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
