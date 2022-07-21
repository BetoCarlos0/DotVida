using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppPersonalSickService : IAppServiceBase<PersonalSick>
    {
        Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id);
    }
}
