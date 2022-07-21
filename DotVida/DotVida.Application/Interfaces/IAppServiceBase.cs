using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Application.Interfaces
{
    public interface IAppServiceBase<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(Guid id);
    }
}
