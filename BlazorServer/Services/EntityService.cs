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

        public async Task<T> EditById(int id, object obj)
        {
            var entity = await _appDbContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentException($"Entity with id {id} not found");
            }

            _appDbContext.Entry(entity).CurrentValues.SetValues(obj);

            await _appDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<List<T>> GetAll()
        {
                if (typeof(T) == typeof(Book))
                {
                    return await _appDbContext.Set<T>()
                       .Include("Author")
                       .Include("Genre")
                       .Include("Publisher")
                        .ToListAsync();
                }

                return await _appDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _appDbContext.Set<T>().FindAsync(id);
        }

        public async Task<bool> Remove(int id)
        {
            var selected = await _appDbContext.Set<T>().FindAsync(id);
            if (selected != null)
            {
                _appDbContext.Set<T>().Remove(selected);
                await _appDbContext.SaveChangesAsync();

                return _appDbContext.Set<T>().Find(id) == null;
            }
            return false;
        }
    }
}
