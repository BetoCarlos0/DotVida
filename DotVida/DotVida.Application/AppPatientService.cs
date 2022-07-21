using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application
{
    public class AppPatientService : AppServiceBase<Patient>, IAppPatientService
    {
        public AppPatientService(IPatientService serviceBase) : base(serviceBase)
        {
        }
    }
}
