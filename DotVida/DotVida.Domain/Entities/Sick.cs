using DotVida.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Sick
    {
        public Guid IdSick { get; set; }

        [Required(ErrorMessage = "Nome da doença vazia")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Tipo da doença vazia")]
        public TypeSick Type { get; set; }

        [Required(ErrorMessage = "Descrição vazia")]
        public string Description { get; set; }
    }
}
