﻿using DotVida.Domain.Entities.Abstracts;
using DotVida.Domain.Interfaces;
using DotVida.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DotVida.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : EntityBase
    {
        private readonly DotVidaDbContext _dbContext;

        public RepositoryBase(DotVidaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsnc(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
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
        public async Task RemoveAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}