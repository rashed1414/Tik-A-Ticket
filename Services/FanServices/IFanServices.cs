using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.FanDTO;

namespace Tik_A_Ticket.Services.FanServices
{
    public interface IFanServices
    {
        Task<ServiceResponse<List<GetFanDto>>> GetAllFans();
        Task<ServiceResponse<GetFanDto>> GetFanById(int id);
        Task<ServiceResponse<GetFanDto>> AddFan(AddFanDto newFan);
        Task<ServiceResponse<GetFanDto>> UpdateFan(int id,AddFanDto updatedFan);
        Task<ServiceResponse<GetFanDto>> PatchFan(int id,AddFanDto patchedFan);

        Task<ServiceResponse<List<GetFanDto>>> DeleteFan(int id);
        
    }
}