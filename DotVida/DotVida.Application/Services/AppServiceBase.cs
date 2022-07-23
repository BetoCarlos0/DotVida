using AutoMapper;
using DotVida.Application.Interfaces;
using DotVida.Domain.Entities.Abstracts;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : EntityBase
    {
        private readonly IServiceBase<T> _serviceBase;
        public AppServiceBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public virtual async Task CreateAsync(T entity)
        {
            await _serviceBase.CreateAsync(entity);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _serviceBase.GetAllAsync();

        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await _serviceBase.GetByIdAsync(Id);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _serviceBase.RemoveAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await _serviceBase.UpdateAsync(entity);
        }
    }
}
