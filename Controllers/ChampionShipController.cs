using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tik_A_Ticket.DTO.ChampionShipDTO;
using Tik_A_Ticket.Services.ChampionShipServices;

namespace Tik_A_Ticket.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ChampionShipController : ControllerBase
{
    
    private readonly IChampionShipServices _championShipService;
    
    public ChampionShipController(IChampionShipServices championShipService)
    {
        _championShipService = championShipService;
    }
    
    [HttpGet("GetAllChampionShips")]
    public async Task<ActionResult<ServiceResponse<List<GetChampionShipDto>>>> GetAllChampionShips()
    {
        var response = await _championShipService.GetAllChampionShips();
        if (response.Success == false)
        {
            return NotFound(response);
        }
        return Ok(response);
    }

    [HttpGet("GetChampionShipById/{id}")]
    public async Task<ActionResult<ServiceResponse<GetChampionShipDto>>> GetChampionShipById(int id)
    {
        var response = await _championShipService.GetChampionShipById(id);
        if (response.Success == false)
        {
            return NotFound(response);
        }
        return Ok(response);
    }
    
    [HttpPost("AddChampionShip")]
    public async Task<ActionResult<ServiceResponse<List<GetChampionShipDto>>>> AddChampionShip(AddChampionShipDto newChampionShip)
    {
        var response = await _championShipService.AddChampionShip(newChampionShip);
        if (response.Success == false)
        {
            return NotFound(response);
        }
        return Ok(response);
    }
    
    [HttpPut("UpdateChampionShip/{id}")]
    public async Task<ActionResult<ServiceResponse<GetChampionShipDto>>> UpdateChampionShip(int id,AddChampionShipDto updatedChampionShip)
    {
        var response = await _championShipService.UpdateChampionShip(id, updatedChampionShip);
        if (response.Success == false)
        {
            return NotFound(response);
        }
        return Ok(response);
    }
    
    [HttpDelete("DeleteChampionShip/{id}")]
    public async Task<ActionResult<ServiceResponse<List<GetChampionShipDto>>>> DeleteChampionShip(int id)
    {
        var response = await _championShipService.DeleteChampionShip(id);
        if (response.Success == false)
        {
            return NotFound(response);
        }
        return Ok(response);
    }
    
    [HttpPatch("PatchChampionShip/{id}")]
    public async Task<ActionResult<ServiceResponse<GetChampionShipDto>>> PatchChampionShip(int id,AddChampionShipDto updatedChampionShip)
    {
        var response = await _championShipService.PatchChampionShip(id, updatedChampionShip);
        if (response.Success == false)
        {
            return NotFound(response);
        }
        return Ok(response);
    }

}