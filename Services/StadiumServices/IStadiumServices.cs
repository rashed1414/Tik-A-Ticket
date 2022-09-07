using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.StadiumDTO;

namespace Tik_A_Ticket.Services.StadiumServices
{
    public interface IStadiumServices
    {
        Task<ServiceResponse<List<GetStadiumDto>>> GetAllStadiums();
        Task<ServiceResponse<GetStadiumDto>> GetStadiumById(int id);
        Task<ServiceResponse<List<GetStadiumDto>>> AddStadium(AddStadiumDto newStadium);
        Task<ServiceResponse<GetStadiumDto>> UpdateStadium(int id,AddStadiumDto updatedStadium);
        Task<ServiceResponse<GetStadiumDto>> PatchStadium(int id,AddStadiumDto patchedStadium);

        Task<ServiceResponse<List<GetStadiumDto>>> DeleteStadium(int id);
        

    }
}