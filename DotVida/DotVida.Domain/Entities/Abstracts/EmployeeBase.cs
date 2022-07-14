using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities.Abstracts
{
    public abstract class EmployeeBase : PersonBase
    {
        [Required(ErrorMessage = "Login vazio")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Senha vazio")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Status do funcionário vazio")]
        public bool EmployeeStatus { get; set; }
    }
}

