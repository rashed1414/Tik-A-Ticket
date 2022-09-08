using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.TicketDTO;
using Tik_A_Ticket.Services.TicketServices;

namespace Tik_A_Ticket.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketServices _ticketServices;
        
        public TicketController(ITicketServices ticketServices)
        {
            _ticketServices = ticketServices;
        }
        
        [HttpGet("GetAllTickets")]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> GetAllTickets()
        {
            var response = await _ticketServices.GetAllTickets();
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpGet("GetTicketById/{id}")]
        public async Task<ActionResult<ServiceResponse<GetTicketDto>>> GetTicketById(int id)
        {
            var response = await _ticketServices.GetTicketById(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPost("AddTicket")]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> AddTicket(AddTicketDto newTicket)
        {
            var response = await _ticketServices.AddTicket(newTicket);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPut("UpdateTicket/{id}")]
        public async Task<ActionResult<ServiceResponse<GetTicketDto>>> UpdateTicket(int id, AddTicketDto updatedTicket)
        {
            var response = await _ticketServices.UpdateTicket(id, updatedTicket);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpDelete("DeleteTicket/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> DeleteTicket(int id)
        {
            var response = await _ticketServices.DeleteTicket(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPatch("PatchTicket/{id}")]
        public async Task<ActionResult<ServiceResponse<GetTicketDto>>> PatchTicket(int id, AddTicketDto updatedTicket)
        {
            var response = await _ticketServices.PatchTicket(id, updatedTicket);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}