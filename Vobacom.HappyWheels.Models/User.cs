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


        public string FullName
        {
            get
            {
                return String.Format("{0} {2}", FirstName, LastName);
            }
        }

    }
}
