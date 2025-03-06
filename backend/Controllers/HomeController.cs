using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AthletiCore.Backend.Models;
using AthletiCore.Backend.Context;
namespace AthletiCore.Backend.Controllers
{
    [ApiController]
    [Route("api/healthcheck")]
    public class HealthCheckController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HealthCheckController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetHealthStatus()
        {
            var users = await _context.users.ToListAsync();
            return Ok(users);
        }
    }
}
