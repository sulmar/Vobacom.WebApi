using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL
{
    public class HappyWheelsContext : DbContext
    {

        #region

        public DbSet<Station> Stations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Bike> Bikes { get; set; }

        public DbSet<Rental> Rentals { get; set; }


        #endregion

        public HappyWheelsContext()
            : base("HappyWheelsConnection")
        {

        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .Property(p => p.FirstName)
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();


            modelBuilder.Entity<Bike>()
                .Property(p => p.SerialNumber)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<Bike>()
                .Property(p => p.Color)
                .HasMaxLength(100);

            base.OnModelCreating(modelBuilder);
        }
    }
}
