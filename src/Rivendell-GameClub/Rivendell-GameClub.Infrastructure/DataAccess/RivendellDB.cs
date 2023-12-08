using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Rivendell_GameClub.Domain.Tables.Entities;
using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.DataAccess
{
    public class RivendellDB : DbContext
    {
        public RivendellDB(DbContextOptions<RivendellDB> options) : base(options)
        {
            
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Game> Games { get; set; }


    }
}
