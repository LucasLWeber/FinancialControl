using FinancialControl.Application.DTOs;
using FluentValidation;

namespace FinancialControl.Application.Validators
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .MaximumLength(256).WithMessage("O nome deve conter no máximo 256 caracteres.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("O sobrenome é obrigatório")
                .MaximumLength(256).WithMessage("O nome deve conter no máximo 256 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório")
                .EmailAddress().WithMessage("Formato de e-mail inválido");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Senha é obrigatória")
                .MinimumLength(8).WithMessage("Senha deve conter no mínimo 8 caracteres");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("Senhas não coincidem");

            RuleFor(x => x.BirthDate)
                .LessThan(DateTime.UtcNow).WithMessage("Data de nascimento inválida");

            RuleFor(x => x.Document)
                .NotEmpty().WithMessage("Documento é obrigatório")
                .Length(11).WithMessage("Documento deve conter exatamente 11 caracteres");
        }
    }
}
