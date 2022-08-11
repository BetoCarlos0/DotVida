using DotVida.Domain.Entities.Abstracts;

namespace DotVida.Application.Dtos
{
    public class DoctorDto : EntityBase
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? BloodType { get; set; }  // tipo sanguíneo
        public bool PersonStatus { get; set; }    // vivo, morto
        public string? RegistrationNumber { get; set; }
        public string? Specialty { get; set; }
        public bool EmployeeStatus { get; set; }
    }
}
