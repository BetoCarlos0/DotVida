namespace DotVida.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task AddAsync(T entity);
    }
}
