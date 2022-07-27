using DotVida.Domain.Entities;
using FluentValidation;

namespace DotVida.Domain.Validators
{
    public class PatientValidator : AbstractValidator<Patient>
    {
        public PatientValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nome obrigatório")
                .NotNull().WithMessage("Nome obrigatório");           
        }
    }
}
