using E_Commerce_Peliculas.Models;

namespace E_Commerce_Peliculas.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBaseRepository, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
