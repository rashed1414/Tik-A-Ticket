using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tik_A_Ticket.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public long TicketNumber { get; set; }
        public Match? Match { get; set; }
        public PricingCategory? Pricing { get; set; }
        public TicketType? Type { get; set; } = TicketType.Regular;
        public RegularSeat? SeatNo { get; set; }= RegularSeat.A1;
        
    }
}