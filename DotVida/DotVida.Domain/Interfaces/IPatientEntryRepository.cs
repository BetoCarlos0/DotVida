using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces
{
    public interface IPatientEntryRepository : IRepositoryBase<PatientEntry>
    {
        Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id);
    }
}
