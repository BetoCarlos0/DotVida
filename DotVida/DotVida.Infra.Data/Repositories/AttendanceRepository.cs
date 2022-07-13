using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class AttendanceRepository : RepositoryBase<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
