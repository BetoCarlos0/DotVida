using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Doctor : Employee
    {
        [Required(ErrorMessage = "Número de registro vazio")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Especialização vazia")]
        public string Specialty { get; set; }
    }
}
