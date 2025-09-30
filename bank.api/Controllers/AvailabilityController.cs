using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bank.Api.Data;

namespace Bank.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvailabilityController : ControllerBase
    {
        private readonly AppDbContext _db;

        public AvailabilityController(AppDbContext db) => _db = db;

        // GET /api/availability?serviceId=1&date=2025-09-20
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int serviceId, [FromQuery] DateTime date)
        {
            var service = await _db.Services.FindAsync(serviceId);
            if (service == null) return BadRequest(new { error = "Service not found" });

            // business hours (example): 09:00 - 18:00
            var dayStart = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0);
            var dayEnd = new DateTime(date.Year, date.Month, date.Day, 18, 0, 0);

            var bookings = await _db.Bookings
                //.Where(b => b.StartAt.Date == date.Date)
                //.OrderBy(b => b.StartAt)
                .ToListAsync();

            var slots = new List<DateTime>();
            var step = TimeSpan.FromMinutes(15); // granularity
            for (var cursor = dayStart; cursor + TimeSpan.FromMinutes(service.Duration) <= dayEnd; cursor = cursor + step)
            {
                var slotStart = cursor;
                var slotEnd = cursor.AddMinutes(service.Duration);

                //var conflict = bookings.Any(b => (slotStart < b.EndAt) && (slotEnd > b.StartAt));
                //if (!conflict)
                //    slots.Add(slotStart);
            }

            var formatted = slots.Select(s => s.ToString("HH:mm")).ToArray();
            return Ok(new { date = date.Date.ToString("yyyy-MM-dd"), serviceId, available = formatted });
        }
    }
}
