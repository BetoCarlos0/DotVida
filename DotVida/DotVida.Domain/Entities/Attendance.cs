using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Attendance // Atendimento
    {
        public Guid IdAttendance { get; set; }

        [Required(ErrorMessage = "Peso vazio")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Altura vazio")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Data vazio")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Doença vazio")]
        public IEnumerable<Personal_Illness> Sick { get; set; }

        public Guid IdDoctor { get; set; }
        public Doctor Doctor { get; set; }

        [Required(ErrorMessage = "Comentário do médico vazio")]
        public string CommentsDoctor { get; set; }
    }
}
