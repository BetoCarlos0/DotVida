using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IPatientEntryService
    {
        Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id);
        Task CreateAsync(PatientEntry entity);
        Task UpdateAsync(PatientEntry entity);
    }
}
