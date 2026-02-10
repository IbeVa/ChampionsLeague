using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class OrderLine
{
    public int OrderLineId { get; set; }

    public int OrderId { get; set; }

    public int? MatchId { get; set; }

    public int SeatTypeId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }

    public bool IsSubscription { get; set; }

    public virtual Match? Match { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual SeatType SeatType { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
