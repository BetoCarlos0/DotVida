using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Repositoies
{
    public interface IPersonalSickRepository : IRepositoryBase<PersonalSick>
    {
        Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id);
    }
}
