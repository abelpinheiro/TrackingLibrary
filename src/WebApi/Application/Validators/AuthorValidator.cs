using Application.DataTransferObjects;
using FluentValidation;

namespace Application.Validators;

public class AuthorValidator : AbstractValidator<AuthorPostRequest>
{
    public AuthorValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a name");
    }
}