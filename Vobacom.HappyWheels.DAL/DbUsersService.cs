using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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

                // Distribution transaction
                // Add reference: System.Transaction

                try
                {
                    using (var transactionScope = new TransactionScope())
                    {
                        using (var context1 = new HappyWheelsContext())
                        {
                            context1.Users.Add(user);

                            await context1.SaveChangesAsync();

                        }

                        using (var context2 = new HappyWheelsContext())
                        {
                            context2.Bikes.Add(bike);

                            await context2.SaveChangesAsync();
                        }

                        transactionScope.Complete();
                    }
                }
                catch (Exception e)
                {
                    throw new ApplicationException("Błąd podczas zakładania konta");
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
