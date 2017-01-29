using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.DAL
{
    public class DbUsersService : IUsersService
    {
        public void Add(User item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(User item)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(User user, Bike bike)
        {
            using (var context = new HappyWheelsContext())
            {
                var transaction = context.Database.BeginTransaction();

                try
                {
                    context.Users.Add(user);

                    await context.SaveChangesAsync();

                    context.Bikes.Add(bike);

                    await context.SaveChangesAsync();

                    transaction.Commit();

                }
                catch (Exception e)
                {
                    transaction.Rollback();

                    throw new ApplicationException("Błąd podczas zakładania konta użytkownika");
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
