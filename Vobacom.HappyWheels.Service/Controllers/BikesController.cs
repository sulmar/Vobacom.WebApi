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
            throw new NotImplementedException();

            return Ok();
        }

        [Route("api/bikes/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var bike = bikesService.Get(id);

            if (bike == null)
                return NotFound();

            return Ok(bike);
        }
    }
}