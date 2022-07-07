using DotVida.Domain.Entities.Enums;
using DotVida.Domain.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DotVida.Domain.Entities;

public class Employee : IPerson
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CPF { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public BloodType BloodType { get; set; }
    public bool PersonStatus { get; set; }

    [Required(ErrorMessage = "Login vazio")]
    public string Login { get; set; }

    [Required(ErrorMessage = "Senha vazio")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Status do funcionário vazio")]
    public bool EmployeeStatus { get; set; }
}
