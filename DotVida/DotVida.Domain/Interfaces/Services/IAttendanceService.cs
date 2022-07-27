using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IAttendanceService
    {
        Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id);
        Task CreateAsync(Attendance entity);
        Task UpdateAsync(Attendance entity);
    }
}
