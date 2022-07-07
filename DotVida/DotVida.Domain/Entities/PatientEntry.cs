using DotVida.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class PatientEntry
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Data de entrada vazia")]
        public string DateEntry { get; set; }

        [Required(ErrorMessage = "Data de saída vazia")]
        public string DateExit { get; set; }

        [Required(ErrorMessage = "Status de entrada vazio")]
        public StatusEntry StatusEntry { get; set; }

        [Required(ErrorMessage = "Atendimento vazio")]
        public IEnumerable<Attendance> Attendance { get; set; }
    }
}
