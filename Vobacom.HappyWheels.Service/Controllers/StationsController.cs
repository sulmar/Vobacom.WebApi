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
        readonly IStationsService stationsService;

        public StationsController()
            : this(new DbStationsService())
        { }

        public StationsController(IStationsService stationsService)
        {
            this.stationsService = stationsService;
        }


        public IHttpActionResult Get()
        {           
            var stations = stationsService.Get();

            if (!stations.Any())
                return NotFound();

            return Ok(stations) ;
        }

        public IHttpActionResult Get(int id)
        {
            var station = stationsService.Get(id);

            if (station == null)
                return NotFound();

            return Ok(station);
        }
    }
}