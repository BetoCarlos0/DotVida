using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class PersonalSickRepository : RepositoryBase<PersonalSick>, IPersonalSickRepository
    {
        public PersonalSickRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
