using Microsoft.AspNetCore.Mvc;

namespace Api_Versioning.Controllers.V1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    // {domain}/api/v1/WeatherForecast
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]

        public string Get() => ".Net Core Web Api Version 1 from WeatherForecast ";
    }
}
