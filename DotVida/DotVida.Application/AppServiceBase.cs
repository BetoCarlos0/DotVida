using DotVida.Application.Interfaces;
using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Application
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : EntityBase
    {

        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
