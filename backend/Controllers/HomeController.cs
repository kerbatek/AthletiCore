using Microsoft.AspNetCore.Mvc;

namespace AthletiCore.Backend.Controllers
{
    [ApiController]
    [Route("api/healthcheck")]
    public class HealthCheckController : Controller
    {
        [HttpGet]
        public IActionResult GetHealthStatus()
        {
            return Ok(new
            {
                status = "Healthy",
                timestamp = DateTime.Now,
            });
        }
    }
}
