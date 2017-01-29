using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Vobacom.HappyWheels.RestApiServices
{
    public abstract class BaseRestApiService
    {
        protected HttpClient client;

        public BaseRestApiService()
            : this("http://localhost:50792/")
        {
            
        }

        public BaseRestApiService(string serviceBaseAddress)
        {
            client = new HttpClient();

            client.BaseAddress = new Uri(serviceBaseAddress);


            client.DefaultRequestHeaders.Add("Secret-Key", "12345");
        }
    }
}
