using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.Models
{
    public class PriceList : Base
    {
        public int PriceListId { get; set; }

        public TimeSpan Period { get; set; }

        public decimal Price { get; set; }
    }
}   
