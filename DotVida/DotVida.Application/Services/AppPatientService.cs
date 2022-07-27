using AutoMapper;
using DotVida.Application.Dtos;
using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppPatientService : IAppPatientService
    {
        private readonly IPatientService _serviceBase;
        private readonly IMapper _mapper;
        public AppPatientService(IPatientService serviceBase, IMapper mapper)
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

        public async Task<HttpResponseMessage> CreateAsync(PatientDto entityDto)
        {
            var entity = _mapper.Map<Patient>(entityDto);
            return await _serviceBase.CreateAsync(entity);
        }

        public async Task UpdateAsync(PatientDto entityDto)
        {
            var entity = _mapper.Map<Patient>(entityDto);
            await _serviceBase.UpdateAsync(entity);
        }

        public async Task<IEnumerable<PatientDto>> GetAllByNameAsync(string name)
        {
            var entity = await _serviceBase.GetAllByNameAsync(name);
            var entityDto = _mapper.Map<IEnumerable<PatientDto>>(entity);

            return entityDto;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _serviceBase.RemoveAsync(id);
        }
    }
}
