using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.RestApiServices
{
    public class BikesRestApiService : BaseRestApiService, IBikesService
    {
        public void Add(Bike item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Bike item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Bike> Get()
        {
            throw new NotImplementedException();
        }

        public Bike Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Bike> Get(BikesSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Bike Get(string serialNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Bike>> GetAsync()
        {
            var uri = "api/bikes";
            var response = await client.GetAsync(uri);

            var bikes = await response.Content.ReadAsAsync<IList<Bike>>();

            return bikes;

        }

        public void Update(Bike item)
        {
            throw new NotImplementedException();
        }
    }
}
