using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Application.Dtos
{
    public class PatientDto : EntityBase
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? BloodType { get; set; }  // tipo sanguíneo
        public bool PersonStatus { get; set; }  // vivo, morto
    }
}
