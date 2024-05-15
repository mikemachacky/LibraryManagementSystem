using BlazorServer.Model;

namespace BlazorServer.Services
{
    public interface IAuthorService
    {
        public Task<List<Author>> GetAllAuthors();
        public Task<Author> AddAuthor(Author author);
        public Task<Author> RemoveAuthor(Author author);
    }
}
