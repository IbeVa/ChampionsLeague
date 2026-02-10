using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class SeatType
{
    public int Id { get; set; }

    public int StadiumId { get; set; }

    public string Name { get; set; } = null!;

    public string Ring { get; set; } = null!;

    public string Side { get; set; } = null!;

    public int Capacity { get; set; }

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

    public virtual Stadium Stadium { get; set; } = null!;

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
}
