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

        public IList<Bike> Get()
        {
            return bikesService.Get();
        }

        public Bike Get(int id)
        {
            return bikesService.Get(id);
        }
    }
}