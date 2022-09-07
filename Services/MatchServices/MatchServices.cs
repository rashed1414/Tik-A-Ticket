using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.MatchDTO;

namespace Tik_A_Ticket.Services.MatchServices
{
    public class MatchServices : IMatchServices
    {
        public async Task<ServiceResponse<List<GetMatchDto>>> GetAllMatches()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetMatchDto>> GetMatchById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Match>>> GetAllMatchesByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetMatchDto>>> AddMatch(AddMatchDto newMatch)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetMatchDto>> UpdateMatch(int id, AddMatchDto updatedMatch)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetMatchDto>> PatchMatch(int id, AddMatchDto patchedMatch)
        {
            throw new NotImplementedException();
        }

       

        public async Task<ServiceResponse<List<GetMatchDto>>> DeleteMatch(int id)
        {
            throw new NotImplementedException();
        }
    }
}