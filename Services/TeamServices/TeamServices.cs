using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.TeamDTO;
using Tik_A_Ticket.Services.MatchServices;

namespace Tik_A_Ticket.Services.TeamServices
{
    public class TeamServices : ITeamServices
    {
        public async Task<ServiceResponse<List<GetTeamDto>>> GetAllTeams()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetTeamDto>> GetTeamById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetTeamDto>>> AddTeam(AddTeamDto newTeam)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetTeamDto>> UpdateTeam(int id, AddTeamDto updatedTeam)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetTeamDto>> PatchTeam(int id, AddTeamDto patchedTeam)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetTeamDto>>> DeleteTeam(int id)
        {
            throw new NotImplementedException();
        }
    }
}