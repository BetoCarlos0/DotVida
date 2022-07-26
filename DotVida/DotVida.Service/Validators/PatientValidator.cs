using DotVida.Application.Dtos;
using FluentValidation;

namespace DotVida.Service.Validators
{
    public class PatientValidator : AbstractValidator<PatientDto>
    {
        public PatientValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Nome Obrigatório");
        }
    }
}
