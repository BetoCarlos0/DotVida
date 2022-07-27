using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Repositoies
{
    public interface IDoctorRepository : IRepositoryBase<Doctor>
    {
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<IEnumerable<Doctor>> GetAllByNameAsync(string name);
        Task<Doctor> GetByIdAsync(Guid Id);
        Task RemoveAsync(Guid id);
    }
}
