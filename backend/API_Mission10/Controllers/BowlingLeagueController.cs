using API_Mission10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Mission10.Controllers
{
    //change the connection so that the url just has /BowlingLeague
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;

        //setting up the constructor
        public BowlingLeagueController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        //joining the two tables and filtering by the two teams needed
        [HttpGet]
        public IEnumerable<object> Get()
        {
            var combinedData = from bowler in _bowlingRepository.Bowlers
                               join team in _bowlingRepository.Teams on bowler.TeamId equals team.TeamId
                               where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                               select new
                               {
                                   BowlerId = bowler.BowlerId,
                                   BowlerLastName = bowler.BowlerLastName,
                                   BowlerFirstName = bowler.BowlerFirstName,
                                   BowlerMiddleInit = bowler.BowlerMiddleInit,
                                   BowlerAddress = bowler.BowlerAddress,
                                   BowlerCity = bowler.BowlerCity,
                                   BowlerState = bowler.BowlerState,
                                   BowlerZip = bowler.BowlerZip,
                                   BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                   TeamName = team.TeamName
                               };

            return combinedData.ToList();


            //var bowlingData = _bowlingRepository.Bowlers.ToArray();

            //return bowlingData;
        }
    }
}
