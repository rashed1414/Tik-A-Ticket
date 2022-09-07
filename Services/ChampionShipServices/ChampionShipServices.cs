using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.ChampionShipDTO;

namespace Tik_A_Ticket.Services.ChampionShipServices
{
    public class ChampionShipServices : IChampionShipServices
    {
        public async Task<ServiceResponse<List<GetChampionShipDto>>> GetAllChampionShips()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetChampionShipDto>> GetChampionShipById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetChampionShipDto>>> AddChampionShip(AddChampionShipDto newChampionShip)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetChampionShipDto>> UpdateChampionShip(int id, AddChampionShipDto updatedChampionShip)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetChampionShipDto>> PatchChampionShip(int id, AddChampionShipDto patchedChampionShip)
        {
            throw new NotImplementedException();
        }

       

        public async Task<ServiceResponse<List<GetChampionShipDto>>> DeleteChampionShip(int id)
        {
            throw new NotImplementedException();
        }
    }
}