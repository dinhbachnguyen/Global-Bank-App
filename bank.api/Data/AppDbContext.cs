using Microsoft.EntityFrameworkCore;
using Bank.Api.Models;

namespace Bank.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Service> Services => Set<Service>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Booking> Bookings => Set<Booking>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed sample services
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Personal Loan Consultation", Price = 50, Duration = 30, Description = "Discuss loan eligibility, terms, and repayment plans with an advisor." },
                new Service { Id = 2, Name = "Investment Advisory", Price = 120, Duration = 45, Description = "Meet with an investment advisor to review portfolio strategies." },
                new Service  { Id = 3, Name = "Account Opening Assistance", Price = 30, Duration = 20, Description = "Guided support for opening checking, savings, or business accounts." },
                new Service { Id = 4, Name = "Mortgage Consultation", Price = 150, Duration = 60, Description = "Understand mortgage options, interest rates, and approval processes." }
            );

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Phone)
                .IsUnique(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
