using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL
{
    public class DbRentalsService : IRentalsService
    {
        public void Add(Rental rental)
        {
            using (var context = new HappyWheelsContext())
            {
                context.Rentals.Add(rental);
                rental.RentDateFrom = DateTime.Now;
                var entities = context.ChangeTracker.Entries();

                context.Entry(rental.StationFrom).State = System.Data.Entity.EntityState.Unchanged;
                context.Entry(rental.Rentee).State = System.Data.Entity.EntityState.Unchanged;
                context.Entry(rental.Bike).State = System.Data.Entity.EntityState.Unchanged;


                 entities = context.ChangeTracker.Entries();
                context.SaveChanges();
            }
        }
    }
}
