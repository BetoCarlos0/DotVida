using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IPersonalSickService : IServiceBase<PersonalSick>
    {
        Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id);
    }
}
