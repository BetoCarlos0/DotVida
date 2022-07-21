using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application
{
    public class AppAttendanceService : AppServiceBase<Attendance>, IAppAttendanceService
    {
        private readonly IAttendanceService _attendanceService;

        public AppAttendanceService(IAttendanceService service) : base(service)
        {
            _attendanceService = service;
        }

        public async Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id)
        {
            return await _attendanceService.GetAllByIdAsync(id);
        }
    }
}
