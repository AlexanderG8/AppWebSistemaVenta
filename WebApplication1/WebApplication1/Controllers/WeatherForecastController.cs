using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> list = new List<WeatherForecast>();
            list.Add(new WeatherForecast() { id = 1, Nombre = "Alexander"});
            list.Add(new WeatherForecast() { id = 2, Nombre = "Marcello"});
            list.Add(new WeatherForecast() { id = 3, Nombre = "Mathew"});
            list.Add(new WeatherForecast() { id = 4, Nombre = "Lia"});
            list.Add(new WeatherForecast() { id = 5, Nombre = "Alexandras"});
            return list;
        }
    }
}
