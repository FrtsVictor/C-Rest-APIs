using FluentValidation;

namespace UserManager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x) //entire entity
                .NotEmpty()
                .WithMessage("Entity can't be empty")
            
                .NotNull()
                .WithMessage("Entity can't be null");

            RuleFor(x=>x.Name)
                .NotEmpty()
                .WithMessage("Name can't be blank")

                .NotNull()
                .WithMessage("Name can't be null");            
            
            RuleFor(x=>x.Name)
                .NotEmpty()
                .WithMessage("Name can't be blank")

                .NotNull()
                .WithMessage("Name can't be null");

                .MinimumLength(3)
                .WithMessage("Name can't have less than 3 characters")

                .MaximumLength(80)
                .WithMessage("Name can't have more than 80 characters");

            RuleFor(x=>x.Password)
                .NotEmpty()
                .WithMessage("Password can't be blank")

                .NotNull()
                .WithMessage("Password can't be null");

                .MinimumLength(6)
                .WithMessage("Password can't have less than 6 characters")

                .MaximumLength(50)
                .WithMessage("Password can't have more than 50 characters");

            RuleFor(x=>x.Email)
                .NotEmpty()
                .WithMessage("Email can't be blank")

                .NotNull()
                .WithMessage("Email can't be null");

                .MinimumLength(10)
                .WithMessage("Email can't have less than 10 characters")

                .MaximumLength(180)
                .WithMessage("Email can't have more than 180 characters")

                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("Email invalid");           
        }
    }
}