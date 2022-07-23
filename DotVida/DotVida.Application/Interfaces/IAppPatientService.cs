using DotVida.Application.Dtos;
using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppPatientService : IAppServiceBase<Patient>
    {
        Task<IEnumerable<PatientDto>> GetAllAsync();
        //Task<PatientDto> GetByIdAsync(Guid Id);
        Task CreateAsync(PatientDto entity);
        Task UpdateAsync(PatientDto entity);
    }
}
