using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class Stadium
{
    public int StadiumId { get; set; }

    public string Name { get; set; } = null!;

    public string Locale { get; set; } = null!;

    public int Capacity { get; set; }

    public virtual ICollection<Club> Clubs { get; set; } = new List<Club>();

    public virtual ICollection<Match> Matches { get; set; } = new List<Match>();

    public virtual ICollection<SeatType> SeatTypes { get; set; } = new List<SeatType>();
}
