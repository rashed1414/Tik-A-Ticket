using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.PlayerDTO;
using Tik_A_Ticket.Services.PlayerServices;

namespace Tik_A_Ticket.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerServices _playerServices;
        
        public PlayerController(IPlayerServices playerServices)
        {
            _playerServices = playerServices;
        }
        
        [HttpGet("GetAllPlayers")]
        public async Task<ActionResult<ServiceResponse<List<GetPlayerDto>>>> GetAllPlayers()
        {
            var response = await _playerServices.GetAllPlayers();
            
            if(response.Success == false)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
        
        [HttpGet("GetPlayerById/{id}")]
        public async Task<ActionResult<ServiceResponse<GetPlayerDto>>> GetPlayerById(int id)
        {
            var response = await _playerServices.GetPlayerById(id);
            
            if(response.Success == false)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
        
        [HttpPost("AddPlayer")]
        public async Task<ActionResult<ServiceResponse<List<GetPlayerDto>>>> AddPlayer(AddPlayerDto newPlayer)
        {
            var response = await _playerServices.AddPlayer(newPlayer);
            
            if(response.Success == false)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
        
        [HttpPut("UpdatePlayer/{id}")]
        public async Task<ActionResult<ServiceResponse<GetPlayerDto>>> UpdatePlayer(int id, AddPlayerDto updatedPlayer)
        {
            var response = await _playerServices.UpdatePlayer(id, updatedPlayer);
            
            if(response.Success == false)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
        
        [HttpDelete("DeletePlayer/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetPlayerDto>>>> DeletePlayer(int id)
        {
            var response = await _playerServices.DeletePlayer(id);
            
            if(response.Success == false)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
        
        [HttpPatch("PatchPlayer/{id}")]
        public async Task<ActionResult<ServiceResponse<GetPlayerDto>>> PatchPlayer(int id, AddPlayerDto updatedPlayer)
        {
            var response = await _playerServices.PatchPlayer(id, updatedPlayer);
            
            if(response.Success == false)
            {
                return NotFound(response);
            }

            return Ok(response);
        }

    }
}