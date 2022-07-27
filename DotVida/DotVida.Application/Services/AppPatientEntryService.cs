using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppPatientEntryService : IAppPatientEntryService
    {
        private readonly IPatientEntryService _patientEntryService;
        public AppPatientEntryService(IPatientEntryService serviceBase)
        {
            _patientEntryService = serviceBase;
        }

        public async Task CreateAsync(PatientEntry entity)
        {
            await _patientEntryService.CreateAsync(entity);
        }

        public async Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id)
        {
            return await _patientEntryService.GetAllByIdAsync(id);
        }

        public async Task UpdateAsync(PatientEntry entity)
        {
            await _patientEntryService.UpdateAsync(entity);
        }
    }
}
