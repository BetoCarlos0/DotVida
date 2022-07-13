using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class PatientEntryRepository : RepositoryBase<PatientEntry>, IPatientEntryRepository
    {
        public PatientEntryRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
