using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.StadiumDTO;
using Tik_A_Ticket.Services.StadiumServices;

namespace Tik_A_Ticket.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StadiumController : ControllerBase
    {
        private readonly IStadiumServices _stadiumServices;
        
        public StadiumController(IStadiumServices stadiumServices)
        {
            _stadiumServices = stadiumServices;
        }
        
        [HttpGet("GetAllStadiums")]
        public async Task<ActionResult<ServiceResponse<List<GetStadiumDto>>>> GetAllStadiums()
        {
            var response = await _stadiumServices.GetAllStadiums();
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpGet("GetStadiumById/{id}")]
        public async Task<ActionResult<ServiceResponse<GetStadiumDto>>> GetStadiumById(int id)
        {
            var response = await _stadiumServices.GetStadiumById(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPost("AddStadium")]
        public async Task<ActionResult<ServiceResponse<List<GetStadiumDto>>>> AddStadium(AddStadiumDto newStadium)
        {
            var response = await _stadiumServices.AddStadium(newStadium);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPut("UpdateStadium/{id}")]
        public async Task<ActionResult<ServiceResponse<GetStadiumDto>>> UpdateStadium(int id, AddStadiumDto updatedStadium)
        {
            var response = await _stadiumServices.UpdateStadium(id, updatedStadium);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpDelete("DeleteStadium/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetStadiumDto>>>> DeleteStadium(int id)
        {
            var response = await _stadiumServices.DeleteStadium(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPatch("PatchStadium/{id}")]
        public async Task<ActionResult<ServiceResponse<GetStadiumDto>>> PatchStadium(int id, AddStadiumDto updatedStadium)
        {
            var response = await _stadiumServices.PatchStadium(id, updatedStadium);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        

    }
}