using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tik_A_Ticket.Models
{
    public class Match
    {
        public int? Id { get; set; }
        public Team? HomeTeam { get; set; }
        public Team? AwayTeam { get; set; }
        public DateTime Date { get; set; } =DateTime.Today;
        public DateTime Time { get; set; } = DateTime.Now;
        public List<Ticket>? Tickets { get; set; }
        public Stadium? Stadium { get; set; }
        ChampionShip? ChampionShip { get; set; }

    }
}