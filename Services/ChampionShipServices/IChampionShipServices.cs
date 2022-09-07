using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.ChampionShipDTO;

namespace Tik_A_Ticket.Services.ChampionShipServices
{
    public interface IChampionShipServices
    {
        Task<ServiceResponse<List<GetChampionShipDto>>> GetAllChampionShips();
        Task<ServiceResponse<GetChampionShipDto>> GetChampionShipById(int id);
        Task<ServiceResponse<List<GetChampionShipDto>>> AddChampionShip(AddChampionShipDto newChampionShip);
        Task<ServiceResponse<GetChampionShipDto>> UpdateChampionShip(int id,AddChampionShipDto updatedChampionShip);
        Task<ServiceResponse<GetChampionShipDto>> PatchChampionShip(int id,AddChampionShipDto patchedChampionShip);
        Task<ServiceResponse<List<GetChampionShipDto>>> DeleteChampionShip(int id);

    }
}