using ExamManagementApp.DataAccessLayer;
using ExamManagementApp.Domain.Entities;
using ExamManagementApp.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace ExamManagementApp.Repositories.Concretes
{

    public class ExamRepository : Repository<Exam>, IExamRepository
    {

        public ExamRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public async override Task<List<Exam>> GetAllAsync()
        {
            return await _dbTable.Include(x => x.Student).Include(x => x.Lesson).ToListAsync();
        }


        public async override Task<Exam> GetByIdAsync(int id)
        {
            return await _dbTable.Include(x => x.Student).Include(x => x.Lesson).FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception();
        }

    }
}
