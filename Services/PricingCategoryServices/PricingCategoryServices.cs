using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tik_A_Ticket.DTO.PricingCategory;

namespace Tik_A_Ticket.Services.PricingCategoryServices
{
    public class PricingCategoryServices : IPricingCategoryServices
    {
        public async Task<ServiceResponse<List<GetPricingCategoryDto>>> GetAllPricingCategories()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetPricingCategoryDto>> GetPricingCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetPricingCategoryDto>>> AddPricingCategory(AddPricingCategoryDto newPricingCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetPricingCategoryDto>> UpdatePricingCategory(int id, AddPricingCategoryDto updatedPricingCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetPricingCategoryDto>> PatchPricingCategory(int id, AddPricingCategoryDto patchedPricingCategory)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetPricingCategoryDto>>> DeletePricingCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}