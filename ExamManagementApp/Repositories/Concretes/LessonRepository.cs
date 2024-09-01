using ExamManagementApp.DataAccessLayer;
using ExamManagementApp.Domain.Entities;
using ExamManagementApp.Repositories.Abstracts;

namespace ExamManagementApp.Repositories.Concretes;


public class LessonRepository : Repository<Lesson>, ILessonRepository
{
    public LessonRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
