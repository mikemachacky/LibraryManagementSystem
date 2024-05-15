using BlazorServer.Model;

namespace BlazorServer.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooks();
        Task<Book> AddBook(Book book);
        Task<Book> RemoveBook(Book book);
    }
}
