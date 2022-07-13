using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;

namespace DotVida.Infra.Data.Repositories
{
    public class Personal_IllnessRepository : RepositoryBase<Personal_Illness>, IPersonal_IllnessRepository
    {
        public Personal_IllnessRepository(DotVidaDbContext dbContext) : base(dbContext)
        {
        }
    }
}
