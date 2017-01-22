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

            using (var context = new HappyWheelsContext())
            {

            }
        }

        public IList<Station> Get()
        {
            throw new NotImplementedException();
        }

        public Station Get(int id)
        {
            using (var context = new HappyWheelsContext())
            {
                return context.Stations.SingleOrDefault(s => s.StationId == id);
            }
        }

        public void Update(Station station)
        {
            using (var context = new HappyWheelsContext())
            {
                Console.WriteLine(context.Entry(station).State);

               // context.Stations.Attach(station);

                Console.WriteLine(context.Entry(station).State);

                context.Entry(station).State = System.Data.Entity.EntityState.Modified;
                Console.WriteLine(context.Entry(station).State);

                context.SaveChanges();

                Console.WriteLine(context.Entry(station).State);

                var entities = context.ChangeTracker.Entries();

            }
        }
    }
}
