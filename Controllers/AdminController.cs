using Microsoft.AspNetCore.Mvc;
using Online_Voting_System_Backend.Models;

namespace Online_Voting_System_Backend.Controllers
{
    [ApiController]
    [Route("admins")]
    public class AdminController : ControllerBase
    {
        private readonly VotingDbContext _context;
        public AdminController(VotingDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Election>> GetAdminById(Guid id)
        {
            var admin = await _context.Admins.FindAsync(id);
            if (admin == null) return NotFound();
            return Ok(admin);
        }
        [HttpPost]
        public async Task<ActionResult<Voter>> CreateAdmin()
        {
            var admin = new Admin
            {

            };
            await _context.Admins.AddAsync(admin);
            await _context.SaveChangesAsync();
            return CreatedAtAction(
                nameof(GetAdminById),
                new { Id = admin.Id},
                admin
            );
        }
    }
}
