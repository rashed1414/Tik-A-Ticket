using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tik_A_Ticket.Data;
using Tik_A_Ticket.DTO.ChampionShipDTO;

namespace Tik_A_Ticket.Services.ChampionShipServices
{
    public class ChampionShipServices : IChampionShipServices
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public ChampionShipServices(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        
        public async Task<ServiceResponse<List<GetChampionShipDto>>> GetAllChampionShips()
        {
            var response = new ServiceResponse<List<GetChampionShipDto>>();
            var dbChampionShips = await _context.ChampionShips.ToListAsync();
            response.Data = dbChampionShips.Select(c => _mapper.Map<GetChampionShipDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetChampionShipDto>> GetChampionShipById(int id)
        {
            var response = new ServiceResponse<GetChampionShipDto>();
            var dbChampionShip = await _context.ChampionShips.FirstOrDefaultAsync(c => c.Id == id);
            response.Data = _mapper.Map<GetChampionShipDto>(dbChampionShip);
            return response;
        }

        public async Task<ServiceResponse<List<GetChampionShipDto>>> AddChampionShip(AddChampionShipDto newChampionShip)
        {
            var response = new ServiceResponse<List<GetChampionShipDto>>();
            var dbChampionShip = _mapper.Map<ChampionShip>(newChampionShip);
            await _context.ChampionShips.AddAsync(dbChampionShip);
            await _context.SaveChangesAsync();
            response.Data = _context.ChampionShips.Select(c => _mapper.Map<GetChampionShipDto>(c)).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetChampionShipDto>> UpdateChampionShip(int id, AddChampionShipDto updatedChampionShip)
        {
            var response = new ServiceResponse<GetChampionShipDto>();
            try
            {
                var dbChampionShip = await _context.ChampionShips.FirstOrDefaultAsync(c => c.Id == id);
                if (dbChampionShip != null)
                {
                    dbChampionShip.Name = updatedChampionShip.Name;
                    dbChampionShip.Country = updatedChampionShip.Country;
                    dbChampionShip.Description = updatedChampionShip.Description;
                    dbChampionShip.Nation = updatedChampionShip.Nation;
                    dbChampionShip.StartDate = updatedChampionShip.StartDate;
                    dbChampionShip.EndDate = updatedChampionShip.EndDate;
                    dbChampionShip.Logo = updatedChampionShip.Logo;
                    dbChampionShip.Teams = updatedChampionShip.Teams;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<GetChampionShipDto>> PatchChampionShip(int id, AddChampionShipDto patchedChampionShip)
        {
            var response = new ServiceResponse<GetChampionShipDto>();
            try
            {
                var dbChampionShip = await _context.ChampionShips.FirstOrDefaultAsync(c => c.Id == id);
                if (dbChampionShip != null)
                {
                    dbChampionShip.Name = patchedChampionShip.Name ?? dbChampionShip.Name;
                    dbChampionShip.Country = patchedChampionShip.Country ?? dbChampionShip.Country;
                    dbChampionShip.Description = patchedChampionShip.Description ?? dbChampionShip.Description;
                    dbChampionShip.Nation = patchedChampionShip.Nation ?? dbChampionShip.Nation;
                    dbChampionShip.StartDate = patchedChampionShip.StartDate ?? dbChampionShip.StartDate;
                    dbChampionShip.EndDate = patchedChampionShip.EndDate ?? dbChampionShip.EndDate;
                    dbChampionShip.Logo = patchedChampionShip.Logo ?? dbChampionShip.Logo;
                    dbChampionShip.Teams = patchedChampionShip.Teams ?? dbChampionShip.Teams;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

       

        public async Task<ServiceResponse<List<GetChampionShipDto>>> DeleteChampionShip(int id)
        {
            var response = new ServiceResponse<List<GetChampionShipDto>>();
            try
            {
                var dbChampionShip = await _context.ChampionShips.FirstOrDefaultAsync(c => c.Id == id);
                if (dbChampionShip != null)
                {
                    _context.ChampionShips.Remove(dbChampionShip);
                    await _context.SaveChangesAsync();
                    response.Data = _context.ChampionShips.Select(c => _mapper.Map<GetChampionShipDto>(c)).ToList();
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}