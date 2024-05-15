using BlazorServer.Model;

namespace BlazorServer.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooks();
    }
}
