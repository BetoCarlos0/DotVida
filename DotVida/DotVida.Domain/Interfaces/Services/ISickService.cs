using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface ISickService
    {
        Task<Sick> GetByIdAsync(Guid Id);
        Task CreateAsync(Sick entity);
        Task UpdateAsync(Sick entity);
    }
}
