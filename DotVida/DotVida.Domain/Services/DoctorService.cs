using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Domain.Services
{
    public class DoctorService : ServiceBase<Doctor>, IDoctorService
    {
        public DoctorService(IDoctorRepository repository) : base(repository)
        {
        }
    }
}
