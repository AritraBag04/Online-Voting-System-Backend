using Microsoft.EntityFrameworkCore;

namespace Online_Voting_System_Backend.Models
{
    public class VotingDbContext: DbContext
    {
        public VotingDbContext(DbContextOptions<VotingDbContext> options)
        : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; } // Admin table
        public DbSet<Candidate> Candidates { get; set; } // Candidate table
        public DbSet<Election> Elections { get; set; } // Elections table
        public DbSet<Election_Result> ElectionResults { get; set; } // Elections Results table
        public DbSet<Party> Partys { get; set; }
        public DbSet<Voter> Voters { get; set; } // Voter table
    }
}
