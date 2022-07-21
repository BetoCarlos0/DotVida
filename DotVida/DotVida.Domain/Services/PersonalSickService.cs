using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Domain.Services
{
    public class PersonalSickService : ServiceBase<PersonalSick>, IPersonalSickService
    {
        private readonly IPersonalSickRepository _repository;

        public PersonalSickService(IPersonalSickRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id)
        {
            return await _repository.GetAllByIdAsync(id);
        }
    }
}
