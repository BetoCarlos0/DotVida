using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Repositories
{
    public class PatientEntryRepository : RepositoryBase<PatientEntry>, IPatientEntryRepository
    {
        private readonly DotVidaDbContext _context;
        public PatientEntryRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<PatientEntry>> GetAllByIdAsync(Guid id)
        {
            return await _context.PatientsEntry.Where(x => x.PatientId.Equals(id)).ToListAsync();
        }
    }
}
