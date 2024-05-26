namespace BlazorServer.Services
{
    public interface IEntityService<T> where T : class
    {
        Task<T> Add(T entity);
        Task<List<T>> GetAll();
        Task<T?> GetById(int id);
        Task<T> EditById(int id, object obj);
        Task Remove(int id);
        Task<List<T>> GetPaged(int page, int pageSize);
        Task<List<T>?> GetByUserId(string userId);
    }

}
