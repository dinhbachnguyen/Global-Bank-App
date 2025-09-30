using System.ComponentModel.DataAnnotations;

namespace Bank.Api.Dtos
{
    public class CreateBookingDto
    {
        [Required] public int ServiceId { get; set; }
        [Required] public DateTime BookingDate { get; set; } 
        [Required] public DateTime BookingTime { get; set; } 
        [Required] [StringLength(200)] public string CustomerName { get; set; } = default!;
        [Required] [StringLength(30)] public string CustomerPhone { get; set; } = default!;
        [EmailAddress] public string? CustomerEmail { get; set; }
        public string? Notes { get; set; }
    }
}
