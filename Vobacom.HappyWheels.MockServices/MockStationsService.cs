using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.MockServices
{
    public class MockStationsService : IStationsService
    {
        private static IList<Station> _Stations = new List<Station>
        {
            new Station
            {
                StationId = 1,
                Number = "ST001",
                Address = "Wschodnia 36d, Toruń",
                Capacity = 10,
                Location = new Location { Latitude = 54.01f, Longitute = 21.04f  }
            },

            new Station
            {
                StationId = 2,
                Number = "ST002",
                Address = "Bulwar, Toruń",
                Capacity = 20,
                Location = new Location { Latitude = 54.31f, Longitute = 21.54f  }
            },


            new Station
            {
                StationId = 3,
                Number = "ST003",
                Address = "Stare Miasto, Toruń",
                Capacity = 15,
                Location = new Location { Latitude = 54.17f, Longitute = 21.64f  }
            },


        };



        public void Add(Station station)
        {
            _Stations.Add(station);

            var maxId = _Stations.Max(s => s.StationId);

            station.StationId = ++maxId;
        }

        public Task AddAsync(Station item)
        {
            return Task.Run(() => Add(item));
        }

        public void Delete(int id)
        {
            var station = Get(id);

            if (station==null)
            {
                throw new KeyNotFoundException($"Station {id} not found");
            }

            _Stations.Remove(station);
        }

        public IList<Station> Get()
        {
            return _Stations;
        }

        public Station Get(int id)
        {
            return _Stations.SingleOrDefault(s => s.StationId == id);
            
        }

        public Task<IList<Station>> GetAsync()
        {
            return Task.Run(() => Get());
        }

        public void Update(Station station)
        {
            
        }
    }
}
