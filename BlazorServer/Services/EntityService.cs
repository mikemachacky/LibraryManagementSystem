using BlazorServer.Data;
using BlazorServer.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Services
{
    public class EntityService<T> : IEntityService<T> where T : class
    {
        private readonly ApplicationDbContext _appDbContext;

        public EntityService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<T> Add(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAll()
        {
                if (typeof(T) == typeof(Book))
                {
                    return await _appDbContext.Set<T>()
                       // .Include("Author")
                       // .Include("Genre")
                       // .Include("Publisher")
                        .ToListAsync();
                }

                return await _appDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> Remove(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
