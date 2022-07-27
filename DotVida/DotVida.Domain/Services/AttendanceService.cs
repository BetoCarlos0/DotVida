using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Domain.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _repository;
        public AttendanceService(IAttendanceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id)
        {
            return await _repository.GetAllByIdAsync(id);
        }

        public async Task CreateAsync(Attendance entity)
        {
            await _repository.CreateAsync(entity);
        }

        public async Task UpdateAsync(Attendance entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
