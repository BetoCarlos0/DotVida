using DotVida.Domain.Entities;
using DotVida.Domain.Interfaces.Repositoies;
using DotVida.Domain.Interfaces.Services;

namespace DotVida.Domain.Services
{
    public class PatientService : ServiceBase<Patient>, IPatientService
    {
        public PatientService(IPatientRepository repository) : base(repository)
        {
        }
    }
}
