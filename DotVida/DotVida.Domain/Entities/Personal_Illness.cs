using DotVida.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Personal_Illness // Enfermidade Pessoal
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Comentário vazio")]
        public string Comments { get; set; }

        [Required(ErrorMessage = "Status da doença vazia")]
        public StatusSick StatusSick { get; set; }  // status enfermidade

        public Guid SickId { get; set; }
        public Sick Sick { get; set; }
    }
}
