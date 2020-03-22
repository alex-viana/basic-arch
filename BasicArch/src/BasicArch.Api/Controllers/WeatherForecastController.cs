using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BasicArch.Api.Controllers
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
        private readonly IProfileService _profileService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProfileService profileService)
        {
            _logger = logger;
            _profileService = profileService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _profileService.CreateProfile(new Domain.Commands.CreateProfileCommand
            {
                AvatarUrl = "teste",
                Id = Guid.NewGuid(),
                Name = "Alex"
            });

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
