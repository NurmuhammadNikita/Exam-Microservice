using General_Motors.Domain.Tables.Entities;
using General_Motors.Domain.Tables.Models;
using Microsoft.EntityFrameworkCore;

namespace General_Motors.Infrastructure.DataAccess
{
    public class GMDB : DbContext
    {
        public GMDB(DbContextOptions<GMDB> options) : base(options)
        {
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<CarStyle> CarStyles { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
