using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheeks.Interfaces
{
    public interface IBikesService : IService<Bike>
    {
        Bike Get(string serialNumber);
    }
}
