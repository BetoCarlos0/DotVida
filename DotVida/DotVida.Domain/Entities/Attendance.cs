using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Attendance // Atendimento
    {
        public Guid IdAttendance { get; set; }

        [Required(ErrorMessage = "Peso vazio")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Altura vazio")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Data vazio")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Doença vazio")]
        public Personal_Illness Sick { get; set; }

        public Guid IdDoctor { get; set; }
        public Doctor Doctor { get; set; }

        [Required(ErrorMessage = "Comentário do médico vazio")]
        public string CommentsDoctor { get; set; }
    }
}
