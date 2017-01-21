using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models
{
    public class User : Base
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        // C# 6.0
        public string FullName => $"{FirstName} {LastName}";

        
        public override string ToString() => FullName;
    }
}
