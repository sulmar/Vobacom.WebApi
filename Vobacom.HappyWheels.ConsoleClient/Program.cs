using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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

            AddStationTest();
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
                Longitute = float.Parse(longitude, CultureInfo.InvariantCulture)
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
