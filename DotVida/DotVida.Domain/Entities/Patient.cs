using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Domain.Entities
{
    public class Patient : PersonBase // Paciente
    {
        public IEnumerable<Personal_Illness> Personal_Illness { get; set; }
        public IEnumerable<PatientEntry> PatientEntry { get; set; }
    }
}
