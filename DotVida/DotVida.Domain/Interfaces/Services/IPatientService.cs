using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<IEnumerable<Patient>> GetAllByNameAsync(string name);
        Task<Patient> GetByIdAsync(Guid Id);
        Task<HttpResponseMessage> CreateAsync(Patient entity);
        Task<HttpResponseMessage> UpdateAsync(Patient entity);
        Task<HttpResponseMessage> RemoveAsync(Guid id);
    }
}
