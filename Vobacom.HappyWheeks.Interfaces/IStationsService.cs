using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheeks.Interfaces
{
    public interface IStationsService
    {
        IList<Station> Get();

        Station Get(int id);

        void Add(Station station);

        void Update(Station station);

        void Delete(int id);
    }
}
