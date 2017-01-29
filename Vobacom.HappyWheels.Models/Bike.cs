using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.Models.Validators;

namespace Vobacom.HappyWheels.Models
{
    [Validator(typeof(BikeValidator))]
    public class Bike : Base
    {
        public int BikeId { get; set; }

        public string SerialNumber { get; set; }

        public string Color { get; set; }

        public BikeType BikeType { get; set; }

        public bool IsActive { get; set; }


        public Location Location { get; set; }

        public override string ToString() => SerialNumber;
    }
}
