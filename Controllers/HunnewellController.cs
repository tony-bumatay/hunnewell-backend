using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("hunnewell")]
    public class HunnewellController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HunnewellController> _logger;

        public HunnewellController(ILogger<HunnewellController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("whatDayIsIt")]
        public string GetDay()
        {
            return DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }
    }
}
