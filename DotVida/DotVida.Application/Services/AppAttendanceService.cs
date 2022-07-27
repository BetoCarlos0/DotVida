using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppAttendanceService : IAppAttendanceService
    {
        private readonly IAttendanceService _attendanceService;

        public AppAttendanceService(IAttendanceService service)
        {
            _attendanceService = service;
        }

        public async Task CreateAsync(Attendance entity)
        {
            await _attendanceService.CreateAsync(entity);
        }

        public async Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id)
        {
            return await _attendanceService.GetAllByIdAsync(id);
        }

        public Task<Attendance> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Attendance entity)
        {
            await _attendanceService.UpdateAsync(entity);
        }
    }
}
