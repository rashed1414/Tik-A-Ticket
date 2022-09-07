namespace Tik_A_Ticket.DTO.TicketDTO;

public class AddTicketDto
{
    public Match? Match { get; set; }
    public Models.PricingCategory? Pricing { get; set; }
    public TicketType? Type { get; set; } = TicketType.Regular;
    public RegularSeat? SeatNo { get; set; }= RegularSeat.A1;
}