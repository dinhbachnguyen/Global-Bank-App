namespace Bank.Api.Dtos
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; } = default!;
        public DateTime BookingDate { get; set; }
        public DateTime BookingTime { get; set; }
        public string CustomerName { get; set; } = default!;
        public string CustomerPhone { get; set; } = default!;
        public string? CustomerEmail { get; set; }
        //public decimal Price { get; set; }
        //public string? Notes { get; set; }
    }
}
