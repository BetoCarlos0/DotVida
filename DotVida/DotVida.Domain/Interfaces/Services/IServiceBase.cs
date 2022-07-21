using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IServiceBase<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(Guid id);
    }
}
