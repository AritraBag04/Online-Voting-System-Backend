using Microsoft.EntityFrameworkCore;

namespace Online_Voting_System_Backend.Models
{
    public class VotingDbContext: DbContext
    {
        public VotingDbContext(DbContextOptions<VotingDbContext> options)
        : base(options)
        {
        }
        public DbSet<Voter> Voters { get; set; } // Your Voter table
        public DbSet<Candidate> Candidates { get; set; } // Candidate table
        public DbSet<Admin> Admin { get; set; } // Admin table
    }
}
