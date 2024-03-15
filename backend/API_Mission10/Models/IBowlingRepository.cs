namespace API_Mission10.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }

        IEnumerable<Team> Teams { get; }
    }
}
