using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VirginMedia.Scenario.Models;
using VirginMedia.Services.Interfaces;

namespace VirginMedia.Scenario.Controllers
{
    public class ScenarioController : Controller
    {

        private readonly IScenario _scenario;
        public ScenarioController(IScenario scenario)
        {
            _scenario = scenario;
        }

        public async Task<IActionResult> Index()
        {
          var data =  await _scenario.GetSummaryPerUser();
            return View(data);
        }

       
    }
}
