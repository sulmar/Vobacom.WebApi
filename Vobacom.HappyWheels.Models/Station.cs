using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models
{
    public class Station : Base
    {
        public int StationId { get; set; }

        public string Number { get; set; }

        public byte Capacity { get; set; }

        public string Address { get; set; }

        public Location Location { get; set; }
    }
}
