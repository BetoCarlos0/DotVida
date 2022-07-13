using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        //private readonly DotVidaDbContext _context;
        public PatientRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
            //_context = dbContext;
        }
    }
}
