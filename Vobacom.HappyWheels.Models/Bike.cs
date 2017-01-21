using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models
{
    public class Bike : Base
    {
        public int BikeId { get; set; }

        public string SerialNumber { get; set; }

        public string Color { get; set; }

        public BikeType BikeType { get; set; }

        public bool IsActive { get; set; }
    }
}
