using APImish10.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APImish10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository {  get; set; }
        public BowlerController(IBowlerRepository temp) {
            _bowlerRepository = temp;
        }
        [HttpGet]
        //public IEnumerable<Bowlers> Get()
        //{
        //    var bowlerData = _bowlerRepository.Bowlers.Where(x => x.TeamName == "Marlins" || x.TeamName == "Sharks")
        //    .ToArray(); // can add .Bowlers.Where(x => x.TeamName = Marlins and sharks).ToArray();

        //    return bowlerData;
        //}
        public IEnumerable<Bowlers> Get()
        {
            var bowlersWithTeams = _bowlerRepository.Bowlers
                .Join(_bowlerRepository.Teams, // Join with Teams
                    bowler => bowler.TeamID,   // Join condition: Bowler's TeamID
                    team => team.TeamID,       // Join condition: Team's TeamID
                    (bowler, team) => new { Bowler = bowler, Team = team }) // Result selector
                .Where(x => x.Team.TeamName == "Sharks" || x.Team.TeamName == "Marlins")
                .Select(x => x.Bowler)
                .ToList();

            return bowlersWithTeams;
        }
    }
}
