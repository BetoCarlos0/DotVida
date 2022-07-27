using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;
using FluentValidation;
using System.Net;

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

        public async Task<HttpResponseMessage> CreateAsync(Patient entity)
        {
            var validator = await _validator.ValidateAsync(entity);

            if (! validator.IsValid)
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                response.Content = new StringContent(validator.ToString());
                //return await Task.FromResult(response);
                return response;
            }
            await _repository.CreateAsync(entity);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public async Task<HttpResponseMessage> UpdateAsync(Patient entity)
        {
            var validator = await _validator.ValidateAsync(entity);

            if (!validator.IsValid)
            {
                var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                response.Content = new StringContent(validator.ToString());
                return await Task.FromResult(response);
            }
            await _repository.UpdateAsync(entity);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public async Task<HttpResponseMessage> RemoveAsync(Guid id)
        {
            await _repository.RemoveAsync(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
