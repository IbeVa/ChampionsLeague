using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class Subscription
{
    public int SubscriptionId { get; set; }

    public string UserId { get; set; } = null!;

    public int SeatTypeId { get; set; }

    public decimal Price { get; set; }

    public string Season { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual SeatType SeatType { get; set; } = null!;
}
