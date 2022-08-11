using DotVida.Domain.Entities;
using FluentValidation;

namespace DotVida.Domain.Validators
{
    public class PatientValidator : AbstractValidator<Patient>
    {
        public PatientValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Campo vazio");

            RuleFor(x => x.CPF)
                .NotEmpty().WithMessage("Campo vazio");

            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("Campo vazio");

            RuleFor(x => x.BloodType)
                .NotEmpty().WithMessage("Campo vazio");
        }
    }
}
