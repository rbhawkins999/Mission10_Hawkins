using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Mission10.Models;

public partial class Team
{
    [Key]
    public int TeamId { get; set; }

    [Required]
    public string TeamName { get; set; } = null!;

    public int? CaptainId { get; set; }

    [JsonIgnore]
    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();

    public virtual ICollection<TourneyMatch> TourneyMatchEvenLaneTeams { get; set; } = new List<TourneyMatch>();

    public virtual ICollection<TourneyMatch> TourneyMatchOddLaneTeams { get; set; } = new List<TourneyMatch>();
}
