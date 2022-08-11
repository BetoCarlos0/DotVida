using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<IEnumerable<Patient>> GetAllByNameAsync(string name);
        Task<Patient> GetByIdAsync(Guid Id);
        Task CreateAsync(Patient entity);
        Task UpdateAsync(Patient entity);
        Task RemoveAsync(Guid id);
    }
}
