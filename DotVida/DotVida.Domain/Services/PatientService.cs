using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;
using FluentValidation;

namespace DotVida.Domain.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;
        private readonly IValidator<Patient> _validator;
        public PatientService(IPatientRepository repository, IValidator<Patient> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<IEnumerable<Patient>> GetAllByNameAsync(string name)
        {
            return await _repository.GetAllByNameAsync(name);
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Patient> GetByIdAsync(Guid Id)
        {
            return await _repository.GetByIdAsync(Id);
        }

        public async Task CreateAsync(Patient entity)
        {
            await _validator.ValidateAsync(entity, x => 
            {
                x.ThrowOnFailures();
                
            });
            
            //if (!validator.IsValid)
                //throw new ArgumentNullException("", validator.Errors.ToString());
            await _repository.CreateAsync(entity);
        }

        public async Task UpdateAsync(Patient entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _repository.RemoveAsync(id);
        }
    }
}
