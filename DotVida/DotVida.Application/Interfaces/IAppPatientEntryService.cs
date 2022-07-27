using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppPatientEntryService
    {
        Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id);
        Task CreateAsync(PatientEntry entity);
        Task UpdateAsync(PatientEntry entity);
    }
}
