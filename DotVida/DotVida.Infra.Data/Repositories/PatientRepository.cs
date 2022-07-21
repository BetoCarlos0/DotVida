using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
