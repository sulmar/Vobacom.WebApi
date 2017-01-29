using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.DAL;
using Vobacom.HappyWheels.MockServices;
using Vobacom.HappyWheels.Models;
using static System.Console;
using static System.Math;

namespace Vobacom.HappyWheels.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurencyTest();


           // Task.Run(()=> TransactionTest());

          //  LinqExpressionTest();


         //   ParallelTest();

           // CalculateAsyncTest();

            //CalculateTest();

            // CancelationTokenTest();

           // SyncTest();


            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

            //AddRentalTest();

            //UpdateStationTest();

            //DeleteStationTest();

            //AddStationTest();
        }

        private static void ConcurencyTest()
        {
            using (var context1 = new HappyWheelsContext())
            using (var context2 = new HappyWheelsContext())
            {
                var user1 = context1.Users.First();

                user1.FirstName = "Marta";

                var user2 = context2.Users.First();
                user2.FirstName = "Alicja";

                context2.SaveChanges();

                Thread.Sleep(1000);

                context1.SaveChanges();



            }
        }

        private static async Task TransactionTest()
        {
            var user = new User
            {
                FirstName = "Kasia",
                LastName = "Sulecka",
                Email = "marcin.sulecki@gmail.com",
                Birthdate = DateTime.Today,
                Gender = Gender.Man,
            };

            var bike = new Bike
            {
                SerialNumber = "R009",
                BikeType = BikeType.Sport,
                Color = "White",
                IsActive = true,
                Location = new Location
                {
                    Latitude = 53.01f,
                    Longitude = 28.52f
                }
            };

            IUsersService service = new DbUsersService();

            try
            {
                await service.AddAsync(user, bike);
            }

            catch(ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void LinqExpressionTest()
        {
            IBikesService service = new DbBikesService();

            var criteria = new BikesSearchCriteria { Color = "Red" };

            var bikes = service.Get(criteria);
        }

        private static void ParallelTest()
        {
            var numbers = new List<int> { 30, 545, 765, 540 };

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);

            //    Thread.Sleep(1000);
            //}

           // numbers.ForEach(item => Send());


            Parallel.ForEach(numbers, item => Send());
        }

        private static void CalculateSyncTest()
        {
            var result = Calculate(1000);

            result = Calculate(result);

            result = Calculate(result);

            Console.WriteLine(result);
        }

        private static async void CalculateAsyncTest()
        {
            var result = await CalculateAsync(1000);

            result = await CalculateAsync(result);

            result = await CalculateAsync(result);

            Console.WriteLine(result);
        }


        private static void CalculateTest()
        {
            var task1 = CalculateAsync(1000)
                .ContinueWith(task => Calculate(task.Result))
                    .ContinueWith(task => Calculate(task.Result));

            Console.WriteLine(task1.Result);

            //result = Calculate(result);

            //Console.WriteLine(result);


            //result = Calculate(result);

            //Console.WriteLine(result);

        }

        private static Task<decimal> CalculateAsync(decimal amount)
        {
            return Task.Run(() => Calculate(amount));
        } 

        private static void Calculate(object result)
        {
            throw new NotImplementedException();
        }

        private static decimal Calculate(decimal amount)
        {

            Console.WriteLine("Calculating...");

            Thread.Sleep(5000);

            Console.WriteLine("Calculated.");

            return amount * 1.1m;
        }



        private static void CancelationTokenTest()
        {
            var cancelToken = new CancellationTokenSource();

            Task.Run(() => DoWork(cancelToken.Token), cancelToken.Token);


            Thread.Sleep(2000);

            cancelToken.Cancel();

        }

        private static void SyncTest()
        {
            var task1 = Task.Run(() => Send());

            task1.Wait();

            var task2 = Task.Run(() => Send());

            //Task.WaitAll(task1, task2);

            Task.WaitAny(task1, task2);

            var task3 = Task.Run(() => Send());

        }

        private static void DoWork(CancellationToken cancelToken)
        {
            while (true)
            {
                if (cancelToken.IsCancellationRequested)
                {
                    return;
                }
                Console.Write("345");
            }
        }

        private static void Send()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine($"Sending... threadid# {threadId}");

            Thread.Sleep(5000);

            Console.WriteLine($"Sent. threadid# {threadId}");
        }

        private static void AddRentalTest()
        {
            var stationId = 1;

            IStationsService stationsService = new DbStationsService();

            var station = stationsService.Get(stationId);

            var rental = new Rental
            {
                Bike = new Bike {  BikeId = 1 },
                Rentee = new User {  UserId = 2},
                StationFrom = station,
            };

            IRentalsService rentalsService = new DbRentalsService();

            rentalsService.Add(rental);


            

        }

        private static void UpdateStationTest()
        {
            var stationId = 1;

            IStationsService stationsService = new DbStationsService();

            var station = stationsService.Get(stationId);

            station.Number = "ST045";

            stationsService.Update(station);
        }

        private static void DeleteStationTest()
        {
            var stationId = 1;

            IStationsService stationsService = new DbStationsService();

            stationsService.Delete(stationId);
        }

        private static void AddStationTest()
        {
            // UI

            Station station = GetStation();

            WriteLine(station.Number);


            // TODO: Dodać do bazy danych

            IStationsService stationsService = new DbStationsService();

            stationsService.Add(station);


        }



        private static Station GetStation()
        {
            Write("Podaj numer stacji: ");

            var number = ReadLine();

            Write("Podaj pojemmność: ");

            var capacity = byte.Parse(ReadLine());

            var x = Abs(capacity) * Sqrt(capacity);

            Write("Podaj adres: ");

            var address = ReadLine();

            Write("Podaj lokalizację (w formacie lat:lng)");

            var locationString = ReadLine();

            var locations = locationString.Split(':');

            var latitude = locations[0];
            var longitude = locations[1];

            var location = new Location
            {
                Latitude = float.Parse(latitude, CultureInfo.InvariantCulture),
                Longitude = float.Parse(longitude, CultureInfo.InvariantCulture)
            };

            // Tworzenie instancji obiektu

            Station station = CreateStation(number, capacity, address, location);
            return station;
        }

        private static Station CreateStation(string number, byte capacity, string address, Location location)
        {
            return new Station
            {
                Number = number,
                Capacity = capacity,
                Address = address,
                Location = location
            };
        }
    }
}
