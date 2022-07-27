using AutoMapper;
using DotVida.Application.Dtos;
using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppDoctorService : IAppDoctorService
    {
        private readonly IDoctorService _serviceBase;
        private readonly IMapper _mapper;
        public AppDoctorService(IDoctorService serviceBase, IMapper mapper)
        {
            _serviceBase = serviceBase;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DoctorDto>> GetAllAsync()
        {
            var entity = await _serviceBase.GetAllAsync();
            var entityDto = _mapper.Map<IEnumerable<DoctorDto>>(entity);

            return entityDto;
        }

        public async Task<DoctorDto> GetByIdAsync(Guid Id)
        {
            var entity = await _serviceBase.GetByIdAsync(Id);
            var entityDto = _mapper.Map<DoctorDto>(entity);

            return entityDto;
        }

        public async Task<IEnumerable<DoctorDto>> GetAllByNameAsync(string name)
        {
            var entity = await _serviceBase.GetAllByNameAsync(name);
            var entityDto = _mapper.Map<IEnumerable<DoctorDto>>(entity);

            return entityDto;
        }

        public async Task CreateAsync(DoctorNewDto entityDto)
        {
            var entity = _mapper.Map<Doctor>(entityDto);
            await _serviceBase.CreateAsync(entity);
        }

        public async Task UpdateAsync(DoctorNewDto entityDto)
        {
            var entity = _mapper.Map<Doctor>(entityDto);
            await _serviceBase.UpdateAsync(entity);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _serviceBase.RemoveAsync(id);
        }
    }
}
