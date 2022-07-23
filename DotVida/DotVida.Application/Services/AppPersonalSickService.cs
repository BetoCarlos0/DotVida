using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application.Services
{
    public class AppPersonalSickService : AppServiceBase<PersonalSick>, IAppPersonalSickService
    {
        private readonly IPersonalSickService _personalSickService;
        public AppPersonalSickService(IPersonalSickService serviceBase) : base(serviceBase)
        {
            _personalSickService = serviceBase;
        }

        public async Task<IEnumerable<PersonalSick>> GetAllByIdAsync(Guid id)
        {
            return await _personalSickService.GetAllByIdAsync(id);
        }
    }
}
