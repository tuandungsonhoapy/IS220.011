using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAFramework.Services;
using Microsoft.AspNetCore.Mvc;

namespace DA.Framework.Controllers
{
    public class PlanetController : Controller
    {
        private readonly PlanetService _planetService;

        private readonly ILogger<PlanetController> _logger;

        public PlanetController(PlanetService planetService, ILogger<PlanetController> logger){
            this._planetService = planetService;
            this._logger = logger;
        }

        [BindProperty(SupportsGet = true, Name = "action")]
        public string Name {set;get;}
        public IActionResult Index()
        {
            return View();
        }
    }
}