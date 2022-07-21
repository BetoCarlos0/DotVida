using DotVida.Application.Interfaces;
using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Application
{
    public class AppDoctorService : AppServiceBase<Doctor>, IAppDoctorService
    {
        public AppDoctorService(IDoctorService serviceBase) : base(serviceBase)
        {
        }
    }
}
