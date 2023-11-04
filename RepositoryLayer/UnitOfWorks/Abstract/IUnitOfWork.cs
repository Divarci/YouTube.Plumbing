using CoreLayer.BaseEntities;
using RepositoryLayer.Repositories.Abstract;

namespace RepositoryLayer.UnitOfWorks.Abstract
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<bool> CommitAsync();
        IGenericRepositories<T> GetGenericRepository<T>() where T : class, IBaseEntity, new();
        ValueTask DisposeAsync();
    }
}
