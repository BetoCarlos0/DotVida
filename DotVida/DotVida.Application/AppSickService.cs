using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application
{
    public class AppSickService : AppServiceBase<Sick>, IAppSickService
    {
        public AppSickService(ISickService serviceBase) : base(serviceBase)
        {
        }
    }
}
