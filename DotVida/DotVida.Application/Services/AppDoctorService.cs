using AutoMapper;
using DotVida.Application.Dtos;
using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppDoctorService : AppServiceBase<Doctor>, IAppDoctorService
    {
        private readonly IDoctorService _serviceBase;
        private readonly IMapper _mapper;
        public AppDoctorService(IDoctorService serviceBase, IMapper mapper) : base(serviceBase)
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
    }
}
