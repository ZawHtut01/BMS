
using BMS.Domain.Entities;
using System.Linq.Expressions;

namespace BMS.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> SingleOrDefault(Expression<Func<T, bool>> predicate);
    }

    public interface IStudentRepository : IGenericRepository<Student> { }

}
