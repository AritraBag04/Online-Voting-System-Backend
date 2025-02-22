using Online_Voting_System_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Online_Voting_System_Backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VoterController : ControllerBase
    {
        private readonly VotingDbContext _context;

        public VoterController(VotingDbContext context)
        {
            _context = context;
        }

        // GET: api/voter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Voter>>> GetVoters()
        {
            var voters = await _context.Voters.ToListAsync();
            return Ok(voters);
        }
        [HttpGet("{id}/image")]
        public IActionResult GetVoterImage(long id)
        {
            var voter = _context.Voters.Find(id);

            if (voter == null || voter.Image == null)
                return NotFound();

            return File(voter.Image, "image/png");
        }
    }
}