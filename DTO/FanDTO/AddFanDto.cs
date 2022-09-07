namespace Tik_A_Ticket.DTO.FanDTO;

public class AddFanDto
{
    public string? Name { get; set; }
    public string? Username { get; set; }
    public byte[]? ProfilePicture { get; set; }
    public Ticket? FanTicket { get; set; }
    public Team[]? FanTeams { get; set; }
    public Player? FavoutritePlayer { get; set; }
}