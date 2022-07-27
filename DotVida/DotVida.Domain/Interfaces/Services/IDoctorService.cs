using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<IEnumerable<Doctor>> GetAllByNameAsync(string name);
        Task<Doctor> GetByIdAsync(Guid Id);
        Task CreateAsync(Doctor entity);
        Task UpdateAsync(Doctor entity);
        Task RemoveAsync(Guid id);
    }
}
