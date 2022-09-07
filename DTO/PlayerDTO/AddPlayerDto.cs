namespace Tik_A_Ticket.DTO.PlayerDTO;

public class AddPlayerDto
{
    public string? Name { get; set; }
    public int PlayerNumber { get; set; }
    public int PlayerAge { get; set; }
    public PlayerPosition PlayerPosition { get; set; }
    public string? PlayerNationality { get; set; }
    public byte[]? PlayerImage { get; set; }
    public Team? Team { get; set; }
}