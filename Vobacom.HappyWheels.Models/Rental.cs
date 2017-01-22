using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models
{
    public class Rental : Base
    {
        public int RentalId { get; set; }

        // Navigation Property
        public Station StationFrom { get; set; }

        public Station StationTo { get; set; }

        public DateTime RentDateFrom { get; set; }

        public DateTime? RentDateTo { get; set; }

        public Bike Bike { get; set; }

        public User Rentee { get; set; }

        public decimal? Cost { get; set; }


    }
}
