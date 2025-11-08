

namespace BMS.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollBackAsync();
        Task<int> SaveChangesAsync();
        int Complete();


        IStudentRepository Student { get; }

    }
}
