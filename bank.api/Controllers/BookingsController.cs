using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bank.Api.Data;
using Bank.Api.Dtos;
using Bank.Api.Models;

namespace Bank.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly ILogger<BookingsController> _logger;

        public BookingsController(AppDbContext db, ILogger<BookingsController> logger)
        {
            _db = db;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookingDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var service = await _db.Services.FindAsync(dto.ServiceId);
            if (service == null) return BadRequest(new { error = "Service not found" });

            // Normalize incoming start time to local (assume client sends local time)
            //var start = DateTime.SpecifyKind(dto.StartAt, DateTimeKind.Unspecified);
            var startDate = dto.BookingDate;
            var startTime = dto.BookingTime;
            var end = startTime.AddMinutes(service.Duration);

            // Check for conflicts: any booking that overlaps for ANY service (or change to check worker)
            bool overlaps = await _db.Bookings.AnyAsync(b =>
                (startDate == b.BookingDate) && 
                (startTime < b.BookingTime.AddMinutes(service.Duration)) && (end > b.BookingTime)
            );

            if (overlaps)
            {
                return Conflict(new { error = "Selected time slot is not available." });
            }

            // Reuse or create customer
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Phone == dto.CustomerPhone);
            if (customer == null)
            {
                customer = new Customer { FullName = dto.CustomerName, Phone = dto.CustomerPhone, Email = dto.CustomerEmail };
                _db.Customers.Add(customer);
                await _db.SaveChangesAsync();
            }

            var booking = new Booking
            {
                ServiceId = service.Id,
                BookingDate = dto.BookingDate,
                BookingTime = dto.BookingTime,
                CustomerName = dto.CustomerName,
                CustomerPhone = dto.CustomerPhone,
            };

            _db.Bookings.Add(booking);
            await _db.SaveChangesAsync();

            var result = new BookingDto
            {
                Id = booking.Id,
                BookingDate = booking.BookingDate,
                BookingTime = booking.BookingTime,
                ServiceId = service.Id,
                ServiceName = service.Name,
                CustomerName = customer.FullName,
                CustomerPhone = customer.Phone,
                CustomerEmail = customer.Email,
            };

            return CreatedAtAction(nameof(Get), new { id = booking.Id }, result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var b = await _db.Bookings
                //.Include(x => x.Service)
                //.Include(x => x.Customer)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (b == null) return NotFound();

            var dto = new BookingDto
            {
                Id = b.Id,
                ServiceId = b.ServiceId,
                //ServiceName = b.Service!.Name,
                //CustomerName = b.Customer!.FullName,
                //CustomerPhone = b.Customer!.Phone,
                //CustomerEmail = b.Customer!.Email,
            };

            return Ok(dto);
        }
    }
}
