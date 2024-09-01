using ExamManagementApp.Domain.Entities.Base;

namespace ExamManagementApp.Repositories.Abstracts;

public interface IRepository<T> where T : BaseEntity
{
    Task<int> CreateAsync(T obj);

    Task<bool> UpdateAsync(T obj);

    Task<bool> DeleteAsync(int id);

    Task<T> GetByIdAsync(int id);

    Task<List<T>> GetAllAsync();
}
