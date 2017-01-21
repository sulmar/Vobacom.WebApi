using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.MockServices;

namespace Vobacom.HappyWheels.UnitTests
{
    [TestClass]
    public class StationsServiceUnitTest
    {
        IStationsService stationsService;


        [TestInitialize]
        public void Init()
        {
            stationsService = new MockStationsService();
        }

        [TestMethod]
        public void GetTest()
        {
            var stations = stationsService.Get();

            Assert.IsNotNull(stations);

            Assert.IsTrue(stations.Any());

        }

        [TestMethod]
        public void GetTest2()
        {
            var stations = stationsService.Get();

            Assert.IsTrue(stations.All(s => !string.IsNullOrEmpty(s.Number)));
        }

        [TestMethod]
        public void GetByIdTest()
        {
            var stationId = 1;

            var station = stationsService.Get(stationId);

            Assert.IsNotNull(station);

            Assert.AreEqual(stationId, station.StationId);

        }

        [TestMethod]
        public void UpdateTest()
        {
            var stationId = 1;
            var number = "ST009";

            var station = stationsService.Get(stationId);

            station.Number = number;

            stationsService.Update(station);

            var station2 = stationsService.Get(stationId);

            Assert.AreEqual(number, station2.Number);

        }
    }
}
