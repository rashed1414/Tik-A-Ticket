namespace Tik_A_Ticket.DTO.FanDTO;

public class RegisterFanDto
{
    public long? FanId { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public byte[]? ProfilePicture { get; set; }
    public Ticket? FanTicket { get; set; }
    public Team[]? FanTeams { get; set; }
    public Player? FavoutritePlayer { get; set; }
}