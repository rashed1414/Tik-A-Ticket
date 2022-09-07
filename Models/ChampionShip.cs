namespace Tik_A_Ticket.Models;

public class ChampionShip
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Team> Teams { get; set; }
}