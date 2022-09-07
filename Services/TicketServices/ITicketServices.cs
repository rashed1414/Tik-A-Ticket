using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.TicketDTO;

namespace Tik_A_Ticket.Services.TicketServices
{
    public interface ITicketServices
    {
        Task<ServiceResponse<List<GetTicketDto>>> GetAllTickets();
        Task<ServiceResponse<GetTicketDto>> GetTicketById(int id);
        Task<ServiceResponse<List<GetTicketDto>>> AddTicket(AddTicketDto newTicket);
        Task<ServiceResponse<GetTicketDto>> UpdateTicket(int id,AddTicketDto updatedTicket);
        Task<ServiceResponse<GetTicketDto>> PatchTicket(int id,AddTicketDto patchedTicket);
        Task<ServiceResponse<List<GetTicketDto>>> DeleteTicket(int id);

    }
}