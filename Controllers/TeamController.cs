using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.TeamDTO;
using Tik_A_Ticket.Services.TeamServices;

namespace Tik_A_Ticket.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamServices _teamServices;
        
        public TeamController(ITeamServices teamServices)
        {
            _teamServices = teamServices;
        }
        
        [HttpGet("GetAllTeams")]
        public async Task<ActionResult<ServiceResponse<List<GetTeamDto>>>> GetAllTeams()
        {
            var response = await _teamServices.GetAllTeams();
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpGet("GetTeamById/{id}")]
        public async Task<ActionResult<ServiceResponse<GetTeamDto>>> GetTeamById(int id)
        {
            var response = await _teamServices.GetTeamById(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPost("AddTeam")]
        public async Task<ActionResult<ServiceResponse<List<GetTeamDto>>>> AddTeam(AddTeamDto newTeam)
        {
            var response = await _teamServices.AddTeam(newTeam);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPut("UpdateTeam/{id}")]
        public async Task<ActionResult<ServiceResponse<GetTeamDto>>> UpdateTeam(int id, AddTeamDto updatedTeam)
        {
            var response = await _teamServices.UpdateTeam(id, updatedTeam);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpDelete("DeleteTeam/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetTeamDto>>>> DeleteTeam(int id)
        {
            var response = await _teamServices.DeleteTeam(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPatch("PatchTeam/{id}")]
        public async Task<ActionResult<ServiceResponse<GetTeamDto>>> PatchTeam(int id, AddTeamDto updatedTeam)
        {
            var response = await _teamServices.PatchTeam(id, updatedTeam);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        

    }
}