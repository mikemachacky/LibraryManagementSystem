using BlazorServer.Components.Pages;
using BlazorServer.Data;
using BlazorServer.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationDbContext _appDbContext;

        public AuthorService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Author> AddAuthor(Author author)
        {
           _appDbContext.Authors.Add(author);
           await _appDbContext.SaveChangesAsync();
           return author;
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            return await _appDbContext.Authors.ToListAsync();
        }

        public async Task<Author> RemoveAuthor(Author author)
        {
            _appDbContext.Authors.Remove(author);
            await _appDbContext.SaveChangesAsync();
            return author;
        }
    }
}
