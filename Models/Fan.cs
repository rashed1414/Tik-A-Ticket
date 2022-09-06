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
        public string? username { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public DateTime? RegesteredDate { get; set; }
    }
}