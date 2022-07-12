using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Patient : PersonBase // Paciente
    {
        [Required(ErrorMessage = "Doença vazia")]
        public IEnumerable<Personal_Illness> Sick { get; set; }

        [Required(ErrorMessage = "Atendimento vazio")]
        public IEnumerable<Attendance> Attendances { get; set; }
    }
}
