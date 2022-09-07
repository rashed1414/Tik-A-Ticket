using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.TicketDTO;

namespace Tik_A_Ticket.Services.TicketServices
{
    public class TicketServices : ITicketServices
    {
        public async Task<ServiceResponse<List<GetTicketDto>>> GetAllTickets()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetTicketDto>> GetTicketById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetTicketDto>>> AddTicket(AddTicketDto newTicket)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetTicketDto>> UpdateTicket(int id, AddTicketDto updatedTicket)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetTicketDto>> PatchTicket(int id, AddTicketDto patchedTicket)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetTicketDto>>> DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }
    }
}