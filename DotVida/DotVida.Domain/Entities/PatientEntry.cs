using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotVida.Domain.Entities
{
    public class PatientEntry : EntityBase // Entrada do paciente
    {
        [Required(ErrorMessage = "Data de entrada vazia")]
        public DateTime DateEntry { get; set; }

        [Required(ErrorMessage = "Data de saída vazia")]
        public DateTime DateExit { get; set; }

        [Required(ErrorMessage = "Status de entrada vazio")]
        public string? StatusEntry { get; set; }

        public Guid PatientId { get; set; }
        [JsonIgnore]
        public Patient? Patient { get; set; }

        [JsonIgnore]
        public IEnumerable<Attendance>? Attendance { get; set; }

        public List<string> GetStatusEntry()
        {
            return new List<string> { "Finalizado", "Em Andamento" };
        }
    }
}
