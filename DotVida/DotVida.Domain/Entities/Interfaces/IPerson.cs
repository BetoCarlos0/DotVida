using DotVida.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities.Interfaces
{
    public interface IPerson
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome vazio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "CPF vazio")]
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
