using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {

            // ToTable("Uzytkownicy");

            Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsConcurrencyToken()
                ;
               // .HasColumnName("Imie");

            Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired()
                .IsConcurrencyToken();
        }
    }
}
