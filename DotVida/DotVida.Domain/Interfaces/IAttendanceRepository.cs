using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces
{
    public interface IAttendanceRepository : IRepositoryBase<Attendance>
    {
        Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id);
    }
}
