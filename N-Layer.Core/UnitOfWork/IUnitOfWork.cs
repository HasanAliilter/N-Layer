using N_Layer.Core.Repositories;

namespace N_Layer.Core.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task CommitAsync();
        Task Commit();
    }
}
