using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


        //public IHttpActionResult Get()
        //{           
        //    var stations = stationsService.Get();

        //    if (!stations.Any())
        //        return NotFound();

        //    return Ok(stations) ;
        //}

        public IHttpActionResult Get(int id)
        {
            var station = stationsService.Get(id);

            if (station == null)
                return NotFound();

            return Ok(station);
        }

        // api/stations?lat=53.01&lng=28.05
        //[HttpGet]
        //public async Task<IHttpActionResult> FindAsync(double lat, double lng)
        //{
        //    throw new NotImplementedException();
        //}

        [HttpGet]
        public async Task<IHttpActionResult> FindAsync([FromUri] Location location)
        {
            throw new NotImplementedException();
        }



    }
}