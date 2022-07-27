using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Domain.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repository;
        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(Doctor entity)
        {
            await _repository.CreateAsync(entity);
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<Doctor>> GetAllByNameAsync(string name)
        {
            return await _repository.GetAllByNameAsync(name);
        }

        public async Task<Doctor> GetByIdAsync(Guid Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _repository.RemoveAsync(id);
        }

        public async Task UpdateAsync(Doctor entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
