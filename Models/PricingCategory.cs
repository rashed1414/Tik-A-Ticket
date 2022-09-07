using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tik_A_Ticket.Models
{
    public class PricingCategory
    {
        public int Id { get; set; }
        public TicketType TicketType { get; set; }
        public double Price { get; set; }

    }
}