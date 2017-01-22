using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL
{
    public class DbStationsService : IStationsService
    {

        public void Print()
        {

        }

        public void Add(Station station)
        {
            using (var context = new HappyWheelsContext())
            {
                context.Stations.Add(station);

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Station> Get()
        {
            throw new NotImplementedException();
        }

        public Station Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Station station)
        {
            throw new NotImplementedException();
        }
    }
}
