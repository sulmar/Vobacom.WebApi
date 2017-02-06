using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Vobacom.HappyWheeks.Interfaces;
using Vobacom.HappyWheels.Models;
using Vobacom.HappyWheels.RestApiServices;

namespace Vobacom.HappyWheels.MVCClient.Controllers
{
    public class BikesController : Controller
    {
        private IBikesService bikesService;

        public BikesController()
            : this(new BikesRestApiService())
        { }

        public BikesController(IBikesService bikesService)
        {
            this.bikesService = bikesService;
        }


        // GET: Bikes
        public async Task<ActionResult> Index()
        {
            var bikes = await bikesService.GetAsync();

            return View(bikes);
        }

        [HttpPost]
        public ActionResult Create(Bike bike)
        {

            if (!ModelState.IsValid)
            { // re-render the view when validation failed.
                return View("Create", bike);
            }

            return RedirectToAction("Index");

        }
    }
}