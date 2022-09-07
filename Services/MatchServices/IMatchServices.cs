using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.MatchDTO;

namespace Tik_A_Ticket.Services.MatchServices
{
    public interface IMatchServices
    {
        Task<ServiceResponse<List<GetMatchDto>>> GetAllMatches();
        Task<ServiceResponse<GetMatchDto>> GetMatchById(int id);
        Task<ServiceResponse<List<Match>>> GetAllMatchesByDate(DateTime date);
        Task<ServiceResponse<List<GetMatchDto>>> AddMatch(AddMatchDto newMatch);
        Task<ServiceResponse<GetMatchDto>> UpdateMatch(int id,AddMatchDto updatedMatch);
        Task<ServiceResponse<GetMatchDto>> PatchMatch(int id,AddMatchDto patchedMatch);

        Task<ServiceResponse<List<GetMatchDto>>> DeleteMatch(int id);
        


    }
}