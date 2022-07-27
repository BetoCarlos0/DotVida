using DotVida.Application.Dtos;
using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppPatientService
    {
        Task<IEnumerable<PatientDto>> GetAllAsync();
        Task<IEnumerable<PatientDto>> GetAllByNameAsync(string name);
        Task<PatientDto> GetByIdAsync(Guid Id);
        Task<HttpResponseMessage> CreateAsync(PatientDto entity);
        Task UpdateAsync(PatientDto entity);
        Task RemoveAsync(Guid id);
    }
}
