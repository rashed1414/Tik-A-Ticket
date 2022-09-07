using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.PlayerDTO;

namespace Tik_A_Ticket.Services.PlayerServices
{
    public interface IPlayerServices
    {
        Task<ServiceResponse<List<GetPlayerDto>>> GetAllPlayers();
        Task<ServiceResponse<GetPlayerDto>> GetPlayerById(int id);
        Task<ServiceResponse<List<GetPlayerDto>>> AddPlayer(AddPlayerDto newPlayer);
        Task<ServiceResponse<GetPlayerDto>> UpdatePlayer(int id,AddPlayerDto updatedPlayer);
        Task<ServiceResponse<GetPlayerDto>> PatchPlayer(int id,AddPlayerDto patchedPlayer);
        Task<ServiceResponse<List<GetPlayerDto>>> DeletePlayer(int id);
        

    }
}