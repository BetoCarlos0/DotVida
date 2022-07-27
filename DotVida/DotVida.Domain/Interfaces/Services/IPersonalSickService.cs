using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IPersonalSickService
    {
        Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id);
        Task CreateAsync(PersonalSick entity);
        Task UpdateAsync(PersonalSick entity);
    }
}
