using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.StadiumDTO;

namespace Tik_A_Ticket.Services.StadiumServices
{
    public class StadiumServices : IStadiumServices
    {
        public async Task<ServiceResponse<List<GetStadiumDto>>> GetAllStadiums()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetStadiumDto>> GetStadiumById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetStadiumDto>>> AddStadium(AddStadiumDto newStadium)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetStadiumDto>> UpdateStadium(int id, AddStadiumDto updatedStadium)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetStadiumDto>> PatchStadium(int id, AddStadiumDto patchedStadium)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetStadiumDto>>> DeleteStadium(int id)
        {
            throw new NotImplementedException();
        }
    }
}