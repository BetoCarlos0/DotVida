using AutoMapper;
using DotVida.Application.Dtos;
using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppPatientService : AppServiceBase<Patient>, IAppPatientService
    {
        private readonly IPatientService _serviceBase;
        private readonly IMapper _mapper;
        private readonly IValidator
        public AppPatientService(IPatientService serviceBase, IMapper mapper) : base(serviceBase)
        {
            _serviceBase = serviceBase;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PatientDto>> GetAllAsync()
        {
            var entity = await _serviceBase.GetAllAsync();
            var entityDto = _mapper.Map<IEnumerable<PatientDto>>(entity);

            return entityDto;
        }

        public async Task<PatientDto> GetByIdAsync(Guid Id)
        {
            var entity = await _serviceBase.GetByIdAsync(Id);
            var entityDto = _mapper.Map<PatientDto>(entity);

            return entityDto;
        }

        public async Task CreateAsync(PatientDto entityDto)
        {
            var entity = _mapper.Map<Patient>(entityDto);
            await _serviceBase.CreateAsync(entity);
        }

        public async Task UpdateAsync(PatientDto entityDto)
        {
            var entity = _mapper.Map<Patient>(entityDto);
            await _serviceBase.UpdateAsync(entity);
        }
    }
}
