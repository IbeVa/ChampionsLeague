using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class Match
{
    public int MatchId { get; set; }

    public int HomeClubId { get; set; }

    public int AwayClubId { get; set; }

    public int StadiumId { get; set; }

    public DateOnly MatchDate { get; set; }

    public string Status { get; set; } = null!;

    public string Season { get; set; } = null!;

    public virtual Club AwayClub { get; set; } = null!;

    public virtual Club HomeClub { get; set; } = null!;

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

    public virtual Stadium Stadium { get; set; } = null!;
}
