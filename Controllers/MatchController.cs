using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.MatchDTO;
using Tik_A_Ticket.Services.MatchServices;

namespace Tik_A_Ticket.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchServices _matchServices;
        
        public MatchController(IMatchServices matchServices)
        {
            _matchServices = matchServices;
        }
        
        [HttpGet("GetAllMatches")]
        public async Task<ActionResult<ServiceResponse<List<GetMatchDto>>>> GetAllMatches()
        {
            var response = await _matchServices.GetAllMatches();
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpGet("GetMatchById/{id}")]
        public async Task<ActionResult<ServiceResponse<GetMatchDto>>> GetMatchById(int id)
        {
            var response = await _matchServices.GetMatchById(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPost("AddMatch")]
        public async Task<ActionResult<ServiceResponse<List<GetMatchDto>>>> AddMatch(AddMatchDto newMatch)
        {
            var response = await _matchServices.AddMatch(newMatch);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPut("UpdateMatch/{id}")]
        public async Task<ActionResult<ServiceResponse<GetMatchDto>>> UpdateMatch(int id, AddMatchDto updatedMatch)
        {
            var response = await _matchServices.UpdateMatch(id, updatedMatch);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpDelete("DeleteMatch/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetMatchDto>>>> DeleteMatch(int id)
        {
            var response = await _matchServices.DeleteMatch(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPatch("PatchMatch/{id}")]
        public async Task<ActionResult<ServiceResponse<GetMatchDto>>> PatchMatch(int id, AddMatchDto updatedMatch)
        {
            var response = await _matchServices.PatchMatch(id, updatedMatch);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        


    }
}