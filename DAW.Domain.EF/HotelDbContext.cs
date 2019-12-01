using DAW.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DAW.Domain.EF
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}