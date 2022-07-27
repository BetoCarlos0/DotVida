using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Repositories
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        private readonly DotVidaDbContext _dbContext;
        public DoctorRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await _dbContext.Doctors.ToListAsync();
        }

        public async Task<IEnumerable<Doctor>> GetAllByNameAsync(string name)
        {
            return await _dbContext.Doctors
                .Where(x => x.Name.Equals(name))
                .ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(Guid Id)
        {
            return await _dbContext.Doctors.FindAsync(Id);
        }

        public async Task RemoveAsync(Guid id)
        {
            var getEntity = await _dbContext.Doctors.FindAsync(id);

            _dbContext.Doctors.Remove(getEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
