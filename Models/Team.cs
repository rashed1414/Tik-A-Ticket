namespace Tik_A_Ticket.Models;

public class Team
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int LeagueOrder { get; set; }
    public List<Player>? Players { get; set; }
    public List<ChampionShip>? ChampionShips { get; set; }
    public byte[]? Logo { get; set; }
}