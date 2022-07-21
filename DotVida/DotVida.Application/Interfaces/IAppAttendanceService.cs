using DotVida.Domain.Entities;

namespace DotVida.Application.Interfaces
{
    public interface IAppAttendanceService : IAppServiceBase<Attendance>
    {
        Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id);
    }
}
