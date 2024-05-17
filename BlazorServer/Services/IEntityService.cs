namespace BlazorServer.Services
{
    public interface IEntityService<T> where T : class
    {
        Task<T> Add(T entity);
        Task<List<T>> GetAll();
        Task<T> Remove(T entity);
    }

}
