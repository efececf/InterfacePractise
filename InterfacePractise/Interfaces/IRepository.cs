namespace InterfacePractise.Interfaces
{
    public interface IRepository<T> where T : class
    {
       Task<List<T>> GetAll();
        Task<T> QuerybyID(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
