using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class SickRepository : RepositoryBase<Sick>, ISickRepository
    {
        public SickRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
