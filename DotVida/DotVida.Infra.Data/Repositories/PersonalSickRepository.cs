using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Repositories
{
    public class PersonalSickRepository : RepositoryBase<PersonalSick>, IPersonalSickRepository
    {
        private readonly DotVidaDbContext _context;
        public PersonalSickRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id)
        {
            return await _context.PersonalSicks
                .Include(x => x.Sick)
                .Where(x => x.PatientId.Equals(id))
                .ToListAsync();
        }
    }
}
