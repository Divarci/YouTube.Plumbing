using CoreLayer.BaseEntities;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Abstract
{
    public interface IGenericRepositories<T> where T:class,IBaseEntity,new()
    {
        Task AddEntityAsync(T entity);
        void UpdatetEntity(T entity);
        void DeletetEntity(T entity);
        IQueryable<T> GetAlltEntityList();
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        Task<T> GetEntityByIdAsync(int id);

    }
}
