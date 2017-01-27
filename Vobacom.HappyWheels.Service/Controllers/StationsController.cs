using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.DAL;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.Service.Controllers
{
    public class StationsController : ApiController
    {
        IStationsService stationsService = new DbStationsService();

        public IList<Station> Get()
        {           
            var stations = stationsService.Get();

            return stations;
        }

        public Station Get(int id)
        {
            var station = stationsService.Get(id);

            return station;
        }
    }
}