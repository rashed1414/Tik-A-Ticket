using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.FanDTO;

namespace Tik_A_Ticket.Services.FanServices
{
    public class FanServices : IFanServices
    {
        public async Task<ServiceResponse<List<GetFanDto>>> GetAllFans()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetFanDto>> GetFanById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetFanDto>> AddFan(AddFanDto newFan)
        {
            throw new NotImplementedException();
        }


        public async Task<ServiceResponse<GetFanDto>> UpdateFan(int id, AddFanDto updatedFan)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetFanDto>> PatchFan(int id, AddFanDto patchedFan)
        {
            throw new NotImplementedException();
        }

        

        public async Task<ServiceResponse<List<GetFanDto>>> DeleteFan(int id)
        {
            throw new NotImplementedException();
        }
    }
}