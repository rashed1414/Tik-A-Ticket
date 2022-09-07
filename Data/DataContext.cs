using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tik_A_Ticket.Data
{

    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ChampionShip> ChampionShips { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Fan> Fans { get; set; }
        public DbSet<PricingCategory> PricingCategories { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}