using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppPersonalSickService : IAppPersonalSickService
    {
        private readonly IPersonalSickService _personalSickService;
        public AppPersonalSickService(IPersonalSickService serviceBase)
        {
            _personalSickService = serviceBase;
        }

        public async Task CreateAsync(PersonalSick entity)
        {
            await _personalSickService.CreateAsync(entity);
        }

        public async Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id)
        {
            return await _personalSickService.GetAllByIdAsync(id);
        }

        public async Task UpdateAsync(PersonalSick entity)
        {
            await _personalSickService.UpdateAsync(entity);
        }
    }
}
