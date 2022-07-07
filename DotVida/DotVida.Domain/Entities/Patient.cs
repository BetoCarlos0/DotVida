using DotVida.Domain.Entities.Enums;
using DotVida.Domain.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities
{
    public class Patient : IPerson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public BloodType BloodType { get; set; }
        public bool PersonStatus { get; set; }

        [Required(ErrorMessage = "Doença vazia")]
        public IEnumerable<Personal_Illness> Sick { get; set; }

        [Required(ErrorMessage = "Atendimento vazio")]
        public IEnumerable<Attendance> Attendances { get; set; }
    }
}
