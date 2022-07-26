using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities.Abstracts
{
    public abstract class PersonBase : EntityBase
    {
        //[Required(ErrorMessage = "Nome vazio")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "CPF vazio")]
        [RegularExpression(@"([0-9]{3}[.]){2}[0-9]{3}[-][0-9]{2}", ErrorMessage = "Formato inválido")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "Idade vazia"), Range(18, 120, ErrorMessage = "Idade inválida")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Sexo vazio")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Tipo sanguíneo vazio")]
        public string? BloodType { get; set; }  // tipo sanguíneo

        [Required(ErrorMessage = "Status da pessoa vazio")]
        public bool PersonStatus { get; set; }    // vivo, morto

        public List<string> GetGenders()
        {
            return new List<string> { "Homem cis", "Mulher cis", "Homem trans", "Mulher trans", "Outros" };
        }

        public List<string> GetBloodTypes()
        {
            return new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
        }
    }
}

