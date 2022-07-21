using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Domain.Services
{
    public class PatientEntryService : ServiceBase<PatientEntry>, IPatientEntryService
    {
        private readonly IPatientEntryRepository _repository;
        public PatientEntryService(IPatientEntryRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id)
        {
            return await _repository.GetAllByIdAsync(id);
        }
    }
}
