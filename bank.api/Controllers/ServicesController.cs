using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bank.Api.Data;

namespace Bank.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ServicesController(AppDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var services = await _db.Services.OrderBy(s => s.Name).ToListAsync();
            return Ok(services);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var s = await _db.Services.FindAsync(id);
            if (s == null) return NotFound();
            return Ok(s);
        }
    }
}
