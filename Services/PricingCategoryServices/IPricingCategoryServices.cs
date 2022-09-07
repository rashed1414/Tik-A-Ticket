using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.PricingCategory;

namespace Tik_A_Ticket.Services.PricingCategoryServices
{
    public interface IPricingCategoryServices
    {
        Task<ServiceResponse<List<GetPricingCategoryDto>>> GetAllPricingCategories();
        Task<ServiceResponse<GetPricingCategoryDto>> GetPricingCategoryById(int id);
        Task<ServiceResponse<List<GetPricingCategoryDto>>> AddPricingCategory(AddPricingCategoryDto newPricingCategory);
        Task<ServiceResponse<GetPricingCategoryDto>> UpdatePricingCategory(int id,AddPricingCategoryDto updatedPricingCategory);
        Task<ServiceResponse<GetPricingCategoryDto>> PatchPricingCategory(int id,AddPricingCategoryDto patchedPricingCategory);

        Task<ServiceResponse<List<GetPricingCategoryDto>>> DeletePricingCategory(int id);
        

    }
}