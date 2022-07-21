using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
