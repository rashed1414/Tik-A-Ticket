﻿namespace Tik_A_Ticket.DTO.ChampionShipDTO;

public class GetChampionShipDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Team>? Teams { get; set; }
}