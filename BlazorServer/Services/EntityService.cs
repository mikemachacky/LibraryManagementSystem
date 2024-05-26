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
            else if (typeof(T) == typeof(Transaction))
            {
                return await _appDbContext.Set<T>()
                        .Include("Book")
                        .ToListAsync();
               
            }


            return await _appDbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            if(typeof(T) == typeof(Book))
            {
                var book = await _appDbContext.Set<Book>()
                                    .Include(b => b.Author)
                                    .Include(b => b.Genre)
                                    .Include(b => b.Publisher)
                                    .FirstOrDefaultAsync(b => b.BookID == id);

                return book as T;
            }
            var result = await _appDbContext.Set<T>().FindAsync(id);

            return result;
        }

        public async Task<List<T>?> GetByUserId(string userId)
        {
            if (typeof(T) == typeof(Transaction))
            {
                return await _appDbContext.Transactions
                            .Include(b => b.Book)
                            .Where(b => b.UserID == userId)
                            .ToListAsync() as List<T>;
            }

            return null;
        }

        public Task<List<T>> GetPaged(int page, int pageSize)
        {
            return _appDbContext.Set<T>().Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task Remove(int id)
        {
            var entity = await GetById(id);
            if (entity != null)
            {
                _appDbContext.Set<T>().Remove(entity);
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}
