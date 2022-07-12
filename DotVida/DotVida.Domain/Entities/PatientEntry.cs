using DotVida.Domain.Entities.Enums;
using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class PatientEntry : EntityBase // Entrada do paciente
    {
        [Required(ErrorMessage = "Data de entrada vazia")]
        public DateTime DateEntry { get; set; }

        [Required(ErrorMessage = "Data de saída vazia")]
        public DateTime DateExit { get; set; }

        [Required(ErrorMessage = "Status de entrada vazio")]
        public StatusEntry StatusEntry { get; set; }

        [Required(ErrorMessage = "Atendimento vazio")]
        public IEnumerable<Attendance> Attendance { get; set; }
    }
}
