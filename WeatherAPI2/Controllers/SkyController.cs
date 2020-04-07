using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeatherAPI2.Controllers
{
    [Route("odata/[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    public class SkyController : ODataController
    {
        private readonly ILogger<SkyController> _logger;

        public SkyController(ILogger<SkyController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// OData Endpoint for Weather Forecast
        /// </summary>
        /// <returns>A list of weather forecasts</returns>
        [HttpGet]
        [EnableQuery]
        public IEnumerable<Sky> Get()
        {
            var sky1 = new Sky {Id = 1, Name = "Sky 1"};

            var sky2 = new Sky {Id = 2, Name = "Sky 2"};

            return new[] {sky1, sky2};
        }
    }
}