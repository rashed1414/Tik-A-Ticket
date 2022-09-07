namespace Tik_A_Ticket.DTO.MatchDTO;

public class GetMatchDto
{
    public Team? HomeTeam { get; set; }
    public Team? AwayTeam { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; } 
    public List<Ticket>? Tickets { get; set; }
    public Stadium? Stadium { get; set; }
    ChampionShip? ChampionShip { get; set; }
}