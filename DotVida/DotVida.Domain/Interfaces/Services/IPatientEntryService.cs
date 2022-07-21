using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IPatientEntryService : IServiceBase<PatientEntry>
    {
        Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id);
    }
}
