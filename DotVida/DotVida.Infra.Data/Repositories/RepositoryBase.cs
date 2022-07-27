using DotVida.Domain.Entities.Abstracts;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly DotVidaDbContext _dbContext;

        public RepositoryBase(DotVidaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
