namespace Bank.Api.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        /// <summary>Duration in minutes</summary>
        public int Duration { get; set; }
    }
}
