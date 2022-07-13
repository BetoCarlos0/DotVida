using DotVida.Domain.Entities.Enums;
using DotVida.Domain.Entities.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Personal_Illness : EntityBase // Enfermidade Pessoal
    {
        [Required(ErrorMessage = "Comentário vazio")]
        public string Comments { get; set; }

        [Required(ErrorMessage = "Status da doença vazia")]
        public StatusSick StatusSick { get; set; }  // status enfermidade

        [Required(ErrorMessage = "Id da doença vazia")]
        public Guid SickId { get; set; }
        [Required(ErrorMessage = "Doença vazia")]
        public Sick Sick { get; set; }
    }
}
