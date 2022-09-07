using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tik_A_Ticket.Models
{
    public class Fan
    {
        public long? FanId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public DateTime? RegesteredDate { get; set; }=DateTime.Now;
        public Ticket? FanTicket { get; set; }
        public Team[]? FanTeams { get; set; }
        public Player? FavoutritePlayer { get; set; }
    }
}