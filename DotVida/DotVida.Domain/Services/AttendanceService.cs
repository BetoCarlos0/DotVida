using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Domain.Services
{
    public class AttendanceService : ServiceBase<Attendance>, IAttendanceService
    {
        private readonly IAttendanceRepository _repository;

        public AttendanceService(IAttendanceRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id)
        {
            return await _repository.GetAllByIdAsync(id);
        }
    }
}
