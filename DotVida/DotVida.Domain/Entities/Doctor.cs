using DotVida.Domain.Entities.Abstracts;
using DotVida.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Doctor : EmployeeBase
    {
        [Required(ErrorMessage = "Número de registro vazio")]
        [RegularExpression(@"[0-9]{6}[C][R][M][/]+([A][CLPM]|[C][E]|[D][F]|[E][S]|[G][O]|[M][TSG]|[BMP][A]|[P][BREI]|[R][JNSOR]|[S][CPE]|[T][O])"
            ,ErrorMessage = "Formato inválido")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Especialização vazia")]
        public Specialty Specialty { get; set; }
    }
}
