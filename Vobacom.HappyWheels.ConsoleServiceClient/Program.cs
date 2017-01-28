using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.RestApiServices;

namespace Vobacom.HappyWheels.ConsoleServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(()=>GetBikesTest());


            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }

        private static async Task GetBikesTest()
        {
            IBikesService bikesService = new BikesRestApiService();

            var bikes = await bikesService.GetAsync();

            bikes.ToList().ForEach(bike => Console.WriteLine(bike));
        }
    }
}
