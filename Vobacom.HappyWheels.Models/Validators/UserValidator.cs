using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty()
                .Length(1, 20)
                .WithMessage("Imię jest za długie");


            RuleFor(p => p.LastName)
                .NotEmpty();

        }
    }
}
