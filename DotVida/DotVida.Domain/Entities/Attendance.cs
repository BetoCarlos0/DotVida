using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Attendance : EntityBase
    {
        [Required(ErrorMessage = "Peso vazio")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Altura vazio")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Data vazio")]
        public DateTime CreatedDate { get; set; }

        public IEnumerable<Personal_Illness> Personal_Illness { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [Required(ErrorMessage = "Comentário do médico vazio")]
        public string CommentsDoctor { get; set; }
    }
}
