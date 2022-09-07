using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.PlayerDTO;

namespace Tik_A_Ticket.Services.PlayerServices
{
    public class PlayerServices : IPlayerServices
    {
        public async Task<ServiceResponse<List<GetPlayerDto>>> GetAllPlayers()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetPlayerDto>> GetPlayerById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetPlayerDto>>> AddPlayer(AddPlayerDto newPlayer)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetPlayerDto>> UpdatePlayer(int id, AddPlayerDto updatedPlayer)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetPlayerDto>> PatchPlayer(int id, AddPlayerDto patchedPlayer)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetPlayerDto>>> DeletePlayer(int id)
        {
            throw new NotImplementedException();
        }
    }
}