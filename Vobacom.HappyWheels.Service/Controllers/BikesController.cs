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

        public IHttpActionResult Get()
        {
            var bikes = bikesService.Get();

            if (!bikes.Any())
                return NotFound();

            return Ok(bikes);
        }

        public IHttpActionResult Get(int id)
        {
            var bike = bikesService.Get(id);

            if (bike == null)
                return NotFound();

            return Ok(bike);
        }
    }
}