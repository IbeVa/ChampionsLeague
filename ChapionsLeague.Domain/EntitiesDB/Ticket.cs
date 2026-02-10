using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int OrderLineId { get; set; }

    public string? SeatNumber { get; set; }

    public decimal Price { get; set; }

    public string Status { get; set; } = null!;

    public string VoucherId { get; set; } = null!;

    public virtual OrderLine OrderLine { get; set; } = null!;
}
