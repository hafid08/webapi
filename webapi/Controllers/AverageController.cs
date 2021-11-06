using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AverageController : ControllerBase
    {
        private readonly ILogger<AverageController> _logger;
        private readonly IWitch _witch;

        public AverageController(ILogger<AverageController> logger, IWitch witch)
        {
            _logger = logger;
            _witch = witch;
        }

        [HttpPost]
        public IActionResult Save([FromBody] List<Person> people)
        {
            double average = new Village(_witch).GetKilledAverage(people);
            return Ok($"So the average is {average}");
        }
    }
}
