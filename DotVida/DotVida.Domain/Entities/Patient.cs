using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Domain.Entities
{
    public class Patient : PersonBase // Paciente
    {
        public IEnumerable<PersonalSick>? PersonalSick { get; set; }
        public IEnumerable<PatientEntry>? PatientEntry { get; set; }
    }
}
