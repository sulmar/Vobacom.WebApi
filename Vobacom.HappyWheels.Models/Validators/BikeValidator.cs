using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models.Validators
{
    public class BikeValidator : AbstractValidator<Bike>
    {
        public BikeValidator()
        {
            RuleFor(p => p.SerialNumber)
                .NotEmpty()
                .Length(1, 10);
        }

    }
}
