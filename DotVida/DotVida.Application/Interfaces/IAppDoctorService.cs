using DotVida.Application.Dtos;
using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppDoctorService : IAppServiceBase<Doctor>
    {
        Task<IEnumerable<DoctorDto>> GetAllAsync();
        Task<DoctorDto> GetByIdAsync(Guid Id);
        Task CreateAsync(DoctorNewDto entity);
        Task UpdateAsync(DoctorNewDto entity);
    }
}
