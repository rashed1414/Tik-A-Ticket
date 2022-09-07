using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.TeamDTO;

namespace Tik_A_Ticket.Services.TeamServices
{
    public interface ITeamServices
    {
        Task<ServiceResponse<List<GetTeamDto>>> GetAllTeams();
        Task<ServiceResponse<GetTeamDto>> GetTeamById(int id);
        Task<ServiceResponse<List<GetTeamDto>>> AddTeam(AddTeamDto newTeam);
        Task<ServiceResponse<GetTeamDto>> UpdateTeam(int id,AddTeamDto updatedTeam);
        Task<ServiceResponse<GetTeamDto>> PatchTeam(int id,AddTeamDto patchedTeam);

        Task<ServiceResponse<List<GetTeamDto>>> DeleteTeam(int id);
        

    }
}