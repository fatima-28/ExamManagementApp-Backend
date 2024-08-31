using ExamManagementApp.DataAccessLayer;
using ExamManagementApp.Domain.Entities.Base;
using ExamManagementApp.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace ExamManagementApp.Repositories.Concretes
{

    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected AppDbContext _appDbContext;

        protected DbSet<T> _dbTable;

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

            _dbTable = appDbContext.Set<T>();
        }

        public virtual async Task<List<T>> GetAllAsync()
        { 
            return await _dbTable.ToListAsync();
        }


        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbTable.FirstOrDefaultAsync(x => x.Id == id) ?? throw new Exception();
        }

        public async Task<int> CreateAsync(T obj)
        {
            var result = await _dbTable.AddAsync(obj);

            await _appDbContext.SaveChangesAsync();

            return result.Entity.Id;
        }

        public async Task<bool> UpdateAsync(T obj)
        {
            _dbTable.Update(obj);

            var result = await _appDbContext.SaveChangesAsync();

            return result >= 1;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var data = await GetByIdAsync(id);

            _dbTable.Remove(data);

            var result = await _appDbContext.SaveChangesAsync();

            return result >= 1;
        }
    }

}
