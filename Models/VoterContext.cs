using Microsoft.EntityFrameworkCore;

namespace Online_Voting_System_Backend.Models
{
    public class VoterContext: DbContext
    {
        public VoterContext(DbContextOptions<VoterContext> options)
        : base(options)
        {
        }

        public DbSet<Voter> TodoItems { get; set; } = null!;
    }
}
