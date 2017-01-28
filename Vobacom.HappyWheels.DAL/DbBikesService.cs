using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL
{
    public class DbBikesService : IBikesService
    {
        public void Add(Bike item)
        {
            using (var context = new HappyWheelsContext())
            {
                context.Bikes.Add(item);

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Bike> Get()
        {
            using (var context = new HappyWheelsContext())
            {
                return context.Bikes.ToList();
            }
        }

        public Bike Get(string serialNumber)
        {
            using (var context = new HappyWheelsContext())
            {
                return context.Bikes
                    .SingleOrDefault(s => s.SerialNumber == serialNumber);
            }
        }

        public Bike Get(int id)
        {
            using (var context = new HappyWheelsContext())
            {
                return context.Bikes.SingleOrDefault(s => s.BikeId == id);
            }
        }

        public void Update(Bike item)
        {
            throw new NotImplementedException();
        }
    }
}
