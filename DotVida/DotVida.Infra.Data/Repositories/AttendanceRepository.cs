using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Repositories
{
    public class AttendanceRepository : RepositoryBase<Attendance>, IAttendanceRepository
    {
        private readonly DotVidaDbContext _context;
        public AttendanceRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<Attendance>> GetAllByIdAsync(Guid id)
        {
            return await _context.Attendances
                .Include(x => x.Doctor)
                .Where(x => x.PatientEntryId.Equals(id))
                .ToListAsync();
        }
    }
}
