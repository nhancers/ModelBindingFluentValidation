using FluentValidation;

namespace FluentValidationSample
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .NotNull()
                .WithErrorCode(ErrorCode.REQUIRED);
        }
    }
}