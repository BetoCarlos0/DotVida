using DotVida.Application.Dtos;
using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppDoctorService
    {
        Task<IEnumerable<DoctorDto>> GetAllAsync();
        Task<IEnumerable<DoctorDto>> GetAllByNameAsync(string name);
        Task<DoctorDto> GetByIdAsync(Guid Id);
        Task CreateAsync(DoctorNewDto entity);
        Task UpdateAsync(DoctorNewDto entity);
        Task RemoveAsync(Guid id);
    }
}
