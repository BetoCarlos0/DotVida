using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Sick : EntityBase
    {
        [Required(ErrorMessage = "Nome da doença vazia")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Tipo da doença vazia")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Descrição vazia")]
        public string Description { get; set; }
    }
}
