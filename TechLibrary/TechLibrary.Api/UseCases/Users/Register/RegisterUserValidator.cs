using FluentValidation;
using TechLibrary.Communication.Requests;

namespace TechLibrary.Api.UseCases.Users.Register;

public class RegisterUserValidator : AbstractValidator<RequestUserJson>
{
    public RegisterUserValidator()
    {
        RuleFor(request => request.Name).NotEmpty().WithMessage("o nome eh obrigatorio!");
        RuleFor(request => request.Email).EmailAddress().WithMessage("o email n eh valido!");
        RuleFor(request => request.Password).NotEmpty().WithMessage("a senha eh obrigatória!");
        When(request => string.IsNullOrEmpty(request.Password) == false, () =>
        {
            RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).NotEmpty().WithMessage("a senha deve ter mais que 6 caracteres!");
        });
    }
}

