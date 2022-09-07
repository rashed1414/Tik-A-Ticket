namespace Tik_A_Ticket.Models;

public class Player
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PlayerNumber { get; set; }
    public int PlayerAge { get; set; }
    public PlayerPosition PlayerPosition { get; set; }
    public string? PlayerNationality { get; set; }
    public byte[]? PlayerImage { get; set; }
    public Team? Team { get; set; }
}