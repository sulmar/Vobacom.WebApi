using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models
{

    public abstract class SearchCriteria : Base
    {

    }

    public abstract class PeriodSearchCriteria : SearchCriteria
    {
        public DateTime? From { get; set; }

        public DateTime? To { get; set; }
    }

    public class BikesSearchCriteria : PeriodSearchCriteria
    {
        public string SerialNumber { get; set; }

        public string Color { get; set; }

        public BikeType? BikeType { get; set; }
    }
}
