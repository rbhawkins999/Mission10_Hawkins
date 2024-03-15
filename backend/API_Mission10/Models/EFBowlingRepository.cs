﻿namespace API_Mission10.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlerContext;

        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;

        public IEnumerable<Team> Teams => _bowlerContext.Teams;
    }
}
