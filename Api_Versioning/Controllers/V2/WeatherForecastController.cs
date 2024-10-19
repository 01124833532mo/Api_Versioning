using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers.V2
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2")]
    // {domain}/api/v2/WeatherForecast
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]

        public string Get() => ".Net Core Web Api Version 2 from WeatherForecast ";
    }
}
