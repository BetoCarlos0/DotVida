using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Domain.Interfaces.Repositoies
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
