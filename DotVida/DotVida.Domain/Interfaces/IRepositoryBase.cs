﻿using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsnc(Guid Id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
