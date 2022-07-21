using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Repositoies
{
    public interface IAttendanceRepository : IRepositoryBase<Attendance>
    {
        Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id);
    }
}
