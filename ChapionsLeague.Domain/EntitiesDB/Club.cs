using System;
using System.Collections.Generic;

namespace ChapionsLeague.Domain.EntitiesDB;

public partial class Club
{
    public int ClubId { get; set; }

    public string Name { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int StadiumId { get; set; }

    public virtual ICollection<Match> MatchAwayClubs { get; set; } = new List<Match>();

    public virtual ICollection<Match> MatchHomeClubs { get; set; } = new List<Match>();

    public virtual Stadium Stadium { get; set; } = null!;
}
