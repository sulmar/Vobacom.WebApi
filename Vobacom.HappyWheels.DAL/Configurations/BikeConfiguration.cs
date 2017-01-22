using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL.Configurations
{
    public class BikeConfiguration : EntityTypeConfiguration<Bike>
    {
        public BikeConfiguration()
        {
             Property(p => p.SerialNumber)
                .HasMaxLength(10)
                .IsRequired();

            Property(p => p.Color)
                .HasMaxLength(100);
        }
    }
}
