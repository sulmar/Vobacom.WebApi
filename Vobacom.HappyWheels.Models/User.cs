using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.Models.Validators;

namespace Vobacom.HappyWheels.Models
{
    [Validator(typeof(UserValidator))]
    public class User : Base, IDisposable
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public DateTime Birthdate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public float? Weight { get; set; }

        public byte[] RowVersion { get; set; }


        // C# 6.0
        public string FullName => $"{FirstName} {LastName}";

        
        public override string ToString() => FullName;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
