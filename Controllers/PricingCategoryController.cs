using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.PricingCategory;
using Tik_A_Ticket.Services.PricingCategoryServices;

namespace Tik_A_Ticket.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PricingCategoryController : ControllerBase
    {
        private readonly IPricingCategoryServices _pricingCategoryServices;
        
        
           public PricingCategoryController(IPricingCategoryServices pricingCategoryServices)
        {
            _pricingCategoryServices = pricingCategoryServices;
        }
           
        [HttpGet("GetAllPricingCategories")]
        public async Task<ActionResult<List<GetPricingCategoryDto>>> GetAllPricingCategories()
        {
            var response = await _pricingCategoryServices.GetAllPricingCategories();
            
            if(response.Success == false)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        
        [HttpGet("GetPricingCategoryById/{id}")]
        public async Task<ActionResult<GetPricingCategoryDto>> GetPricingCategoryById(int id)
        {
            var response = await _pricingCategoryServices.GetPricingCategoryById(id);
            
            if(response.Success == false)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        
        [HttpPost("AddPricingCategory")]
        public async Task<ActionResult<GetPricingCategoryDto>> AddPricingCategory(AddPricingCategoryDto newPricingCategory)
        {
            var response = await _pricingCategoryServices.AddPricingCategory(newPricingCategory);
            
            if(response.Success == false)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        
        [HttpPut("UpdatePricingCategory/{id}")]
        public async Task<ActionResult<GetPricingCategoryDto>> UpdatePricingCategory(int id, AddPricingCategoryDto updatedPricingCategory)
        {
            var response = await _pricingCategoryServices.UpdatePricingCategory(id, updatedPricingCategory);
            
            if(response.Success == false)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        
        [HttpDelete("DeletePricingCategory/{id}")]
        public async Task<ActionResult<GetPricingCategoryDto>> DeletePricingCategory(int id)
        {
            var response = await _pricingCategoryServices.DeletePricingCategory(id);
            
            if(response.Success == false)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
        
        [HttpPatch("PatchPricingCategory/{id}")]
        public async Task<ActionResult<GetPricingCategoryDto>> PatchPricingCategory(int id, AddPricingCategoryDto updatedPricingCategory)
        {
            var response = await _pricingCategoryServices.PatchPricingCategory(id, updatedPricingCategory);
            
            if(response.Success == false)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}