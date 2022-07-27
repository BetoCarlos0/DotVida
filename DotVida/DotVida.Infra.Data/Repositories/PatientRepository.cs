using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        private readonly DotVidaDbContext _context;
        public PatientRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<IEnumerable<Patient>> GetAllByNameAsync(string name)
        {
            return await _context.Patients
                .Where(x => x.Name.Equals(name))
                .ToListAsync();
        }

        public async Task<Patient> GetByIdAsync(Guid Id)
        {
            return await _context.Patients.FindAsync(Id);
        }

        public async Task RemoveAsync(Guid id)
        {
            var getEntity = await _context.Patients.FindAsync(id);

            _context.Patients.Remove(getEntity);
            await _context.SaveChangesAsync();
        }
    }
}
