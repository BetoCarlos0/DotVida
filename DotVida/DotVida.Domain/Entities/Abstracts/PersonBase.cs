using DotVida.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities.Abstracts
{
    public abstract class PersonBase : EntityBase
    {
        [Required(ErrorMessage = "Nome vazio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CPF vazio")]
        [RegularExpression(@"([0-9]{3}[.]){2}[0-9]{3}[-][0-9]{2}", ErrorMessage = "Formato inválido")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Idade vazia")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Sexo vazio")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Tipo sanguíneo vazio")]
        public BloodType BloodType { get; set; }  // tipo sanguíneo

        [Required(ErrorMessage = "Status da pessoa vazio")]
        public bool PersonStatus { get; set; }    // vivo, morto
    }
}

