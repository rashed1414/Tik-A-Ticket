using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.FanDTO;
using Tik_A_Ticket.Services.FanServices;

namespace Tik_A_Ticket.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class FanController : ControllerBase
    {
        private readonly IFanServices _fanServices;
        public FanController(IFanServices fanServices)
        {
            _fanServices = fanServices;
        }
        
        [HttpGet("GetAllFans")]
        public async Task<ActionResult<ServiceResponse<List<GetFanDto>>>> GetAllFans()
        {
            var response = await _fanServices.GetAllFans();
            if(response.Success == false)
            {
                return NotFound(response);
            }
return Ok(response);
        }
        
        [HttpGet("GetFanById/{id}")]
        public async Task<ActionResult<ServiceResponse<GetFanDto>>> GetFanById(int id)
        {
            var response = await _fanServices.GetFanById(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPost("AddFan")]
        public async Task<ActionResult<ServiceResponse<List<GetFanDto>>>> AddFan(AddFanDto newFan)
        {
            var response = await _fanServices.AddFan(newFan);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPut("UpdateFan/{id}")]
        public async Task<ActionResult<ServiceResponse<GetFanDto>>> UpdateFan(int id,AddFanDto updatedFan)
        {
            var response = await _fanServices.UpdateFan(id,updatedFan);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpDelete("DeleteFan/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetFanDto>>>> DeleteFan(int id)
        {
            var response = await _fanServices.DeleteFan(id);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        
        [HttpPatch("PatchFan/{id}")]
        public async Task<ActionResult<ServiceResponse<GetFanDto>>> PatchFan(int id,AddFanDto updatedFan)
        {
            var response = await _fanServices.PatchFan(id,updatedFan);
            if(response.Success == false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}