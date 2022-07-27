using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppAttendanceService
    {
        Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id);
        Task CreateAsync(Attendance entity);
        Task UpdateAsync(Attendance entity);
    }
}
