using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tik_A_Ticket.Models
{
    public class Match
    {
        public int? Id { get; set; }
        public string? HomeTeam { get; set; }
        public string? AwayTeam { get; set; }
        public DateOnly? Date { get; set; } = new DateOnly();
        public TimeOnly? Time { get; set; } = new TimeOnly();
        public string? Stadium { get; set; }
        
    }
}