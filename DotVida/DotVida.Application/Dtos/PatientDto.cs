using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Application.Dtos
{
    public class PatientDto : EntityBase
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Gender { get; set; }
        public bool PersonStatus { get; set; }  // vivo, morto
    }
}
