using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
    public class HairSalonContext : DbContext
    {
        // to access database and tables in database
        public DbSet<Stylist> Stylists { get; set; }

        public DbSet<Client> Clients { get; set; }

        public HairSalonContext(DbContextOptions options) : base(options) { }
    }
}