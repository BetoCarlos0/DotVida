using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Repositoies
{
    public interface IPatientRepository : IRepositoryBase<Patient>
    {
        Task<IEnumerable<Patient>> GetAllAsync();
        Task<IEnumerable<Patient>> GetAllByNameAsync(string name);
        Task<Patient> GetByIdAsync(Guid Id);
        Task RemoveAsync(Guid id);
    }
}
