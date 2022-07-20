using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DotVida.Domain.Entities
{
    public class Attendance : EntityBase
    {
        public Guid PatientEntryId { get; set; }

        [Required(ErrorMessage = "Peso vazio")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Altura vazio")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Data vazio")]
        public DateTime CreatedDate { get; set; }


        [JsonIgnore]
        public IEnumerable<PersonalSick>? PersonalSick { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        [Required(ErrorMessage = "Comentário do médico vazio")]
        public string? CommentsDoctor { get; set; }
    }
}
