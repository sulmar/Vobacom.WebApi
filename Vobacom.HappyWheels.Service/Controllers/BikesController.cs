using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.DAL;
using Vobacom.HappyWheels.Models;

namespace Vobacom.HappyWheels.Service.Controllers
{
    public class BikesController : ApiController
    {
        readonly IBikesService bikesService;

        public BikesController()
            : this(new DbBikesService())
        {

        }

        public BikesController(IBikesService bikesService)
        {
            this.bikesService = bikesService;
        }

        [Route("api/bikes/{serialNumber}")]
        public IHttpActionResult Get(string serialNumber)
        {
            var bike = bikesService.Get(serialNumber);

            if (bike == null)
                return NotFound();

            return Ok(bike);
        }

        [Route("api/bikes/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var bike = bikesService.Get(id);

            if (bike == null)
                return NotFound();

            return Ok(bike);
        }

        //public IHttpActionResult Get()
        //{
        //    var bikes = bikesService.Get();

        //    return Ok(bikes);
        //}


        public async Task<IHttpActionResult> Get()
        {
            var bikes = await bikesService.GetAsync();

            return Ok(bikes);
        }





        public IHttpActionResult Post(Bike bike)
        {
            bikesService.Add(bike);

            var uri = Url.Link("DefaultApi", new { id = bike.BikeId });

            return Created(uri, bike);
        }


        [Route("api/Bikes/{id}")]
        public IHttpActionResult Put(int id, Bike bike)
        {
            if (id != bike.BikeId)
                return BadRequest();

            bikesService.Update(bike);

            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("api/Bikes/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                bikesService.Delete(id);
            }
            catch(KeyNotFoundException)
            {
                return NotFound();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok();
        }
    }
}