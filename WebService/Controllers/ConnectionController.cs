using BearHunt.WedNight.WebService.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BearHunt.WedNight.WebService
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionController : BaseController
    {
        private IConfiguration _config;
        private readonly ILogger<WeatherForecastController> _logger;

        public ConnectionController(ILogger<WeatherForecastController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Token([FromBody] ConnectionModel model)
        {
            const string func = "Token";
            try
            {
                if (model == null)
                {
                    return Unauthorized();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{func}: Exception caugth.", func);
                return StatusCode(500);
            }
        }
    }
}
