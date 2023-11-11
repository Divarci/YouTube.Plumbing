using CoreLayer.BaseEntities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Repositories.Abstract;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Concrete
{
    public class GenericRepositories<T> : IGenericRepositories<T> where T: class,IBaseEntity, new()
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;   

        public GenericRepositories(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }



        public async Task AddEntityAsync(T entity)
        {
            await _dbSet.AddAsync(entity);          
        }

        public void UpdatetEntity(T entity)
        {
            _dbSet.Update(entity);
        }

        public void DeletetEntity(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> GetAlltEntityList()
        {
            return _dbSet.AsNoTracking().AsQueryable();             
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public async Task<T> GetEntityByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> GetAllCount()
        {
            return await _dbSet.CountAsync();
        }


    }
}
