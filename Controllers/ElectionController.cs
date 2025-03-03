using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Voting_System_Backend.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Online_Voting_System_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElectionController : ControllerBase
    {
        private readonly VotingDbContext _context;
        public ElectionController(VotingDbContext context) 
        {
            _context = context; 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Election>> GetElectionById(Guid id)
        {
            var election = await _context.Elections.FindAsync(id);
            if (election == null) return NotFound();
            return Ok(election);
        }

        [HttpPost]
        public async Task<ActionResult<Voter>> CreateElection([FromForm] Guid admin_id, [FromForm] DateTime start_date, [FromForm] DateTime end_date)
        {
            if (admin_id == Guid.Empty || start_date == default || end_date == default)
                return BadRequest("Name and image are required.");
            var election = new Election
            {
                AdminId = admin_id,
                StartDate = start_date,
                EndDate = end_date
            };
            await _context.Elections.AddAsync(election);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetElectionById), 
                new { id = election.Id },
                election
            );

        }
    }
}
