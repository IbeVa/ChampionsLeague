using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class Order
{
    public int OrderId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
}
