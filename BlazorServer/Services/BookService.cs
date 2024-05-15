using BlazorServer.Data;
using BlazorServer.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _appDbContext;

        public BookService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Book>> GetAllBooks()
        {
           return await _appDbContext.Books.ToListAsync();
        }
    }
}
