using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotVida.Domain.Entities
{
    public class PersonalSick : EntityBase // doença pessoal
    {
        [Required(ErrorMessage = "Comentário vazio")]
        public string? Comments { get; set; }

        [Required(ErrorMessage = "Status da doença vazia")]
        public string? StatusSick { get; set; }  // status enfermidade

        //[JsonIgnore]
        public Guid SickId { get; set; }

        [Required(ErrorMessage = "Doença vazia")]
        public Sick? Sick { get; set; }

        public Guid PatientId { get; set; }

        public Guid AttendanceId { get; set; }

        public List<string> GetStatusSick()
        {
            return new List<string> { "Curado", "Doente", "Em tratamento" };
        }
    }
}
