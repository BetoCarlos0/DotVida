using DotVida.Domain.Entities;

namespace DotVida.Domain.Interfaces.Services
{
    public interface IAttendanceService : IServiceBase<Attendance>
    {
        Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id);
    }
}
