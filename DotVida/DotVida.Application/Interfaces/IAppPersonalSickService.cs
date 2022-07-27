using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppPersonalSickService
    {
        Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id);
        Task CreateAsync(PersonalSick entity);
        Task UpdateAsync(PersonalSick entity);
    }
}
