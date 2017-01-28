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
    public class BikesRestApiService : IBikesService
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

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50792/");

            var response = await client.GetAsync(uri);

            var content = await response.Content.ReadAsStringAsync();

            throw new NotImplementedException();

        }

        public void Update(Bike item)
        {
            throw new NotImplementedException();
        }
    }
}
