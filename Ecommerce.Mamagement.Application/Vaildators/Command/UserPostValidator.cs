using FluentValidation;
using Ecommerce.Management.Domain.Request.Command.User;
using Ecommerce.Management.Application.Interfaces.Queries;

public class UserPostValidator : AbstractValidator<CreateUserCommand>
{
    private readonly IUserQueryRepository _userQueryRepository;

    public UserPostValidator(IUserQueryRepository userQueryRepository)
    {
        RuleFor(p => p.FirstName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(70).WithMessage("{PropertyName} must be fewer than 70 characters");

        RuleFor(p => p.LastName)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull().WithMessage("{PropertyName} is required")
            .MaximumLength(70).WithMessage("{PropertyName} must be fewer than 70 characters");

        RuleFor(p => p.Username)
            .NotEmpty().WithMessage("{PropertyName} is required");

        RuleFor(p => p.Email)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .EmailAddress().WithMessage("{PropertyName} must be a valid email address");

        RuleFor(p => p.Password)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .MinimumLength(6).WithMessage("{PropertyName} must be at least 6 characters long");

        RuleFor(p => p.BirthOfDate)
            .NotNull().WithMessage("{PropertyName} is required");

        RuleFor(p => p.MobileNumber)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .Matches(@"^[0-9]+$").WithMessage("{PropertyName} must contain only digits");

        RuleFor(q => q)
            .MustAsync(IsUsernameUniqueAsync)
            .WithMessage("User already exists");

        RuleFor(q => q)
           .MustAsync(IsEmailUniqueAsync)
           .WithMessage("Leave type already exists");

        this._userQueryRepository = userQueryRepository;

    }

    private  Task<bool> IsEmailUniqueAsync(CreateUserCommand command, CancellationToken token)
    {
        return _userQueryRepository.IsEmailUniqueAsync(command.Email);
    }

    private Task<bool> IsUsernameUniqueAsync(CreateUserCommand command, CancellationToken token)
    {
        return _userQueryRepository.IsUsernameUniqueAsync(command.Username);
    }
}
