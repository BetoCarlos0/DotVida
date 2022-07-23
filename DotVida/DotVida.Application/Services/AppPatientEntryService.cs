using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppPatientEntryService : AppServiceBase<PatientEntry>, IAppPatientEntryService
    {
        private readonly IPatientEntryService _patientEntryService;
        public AppPatientEntryService(IPatientEntryService serviceBase) : base(serviceBase)
        {
            _patientEntryService = serviceBase;
        }

        public async Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id)
        {
            return await _patientEntryService.GetAllByIdAsync(id);
        }
    }
}
