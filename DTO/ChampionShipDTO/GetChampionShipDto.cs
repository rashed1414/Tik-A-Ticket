namespace Tik_A_Ticket.DTO.ChampionShipDTO;

public class GetChampionShipDto
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Team>? Teams { get; set; }
    public string? Country { get; set; }
    public string? Nation { get; set; }
    public byte[]? Logo { get; set; }
    public DateTime? StartDate { get; set; }=DateTime.Now;
    public DateTime? EndDate { get; set; }=DateTime.Now;
}