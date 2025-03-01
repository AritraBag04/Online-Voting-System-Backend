using System.ComponentModel.DataAnnotations;

namespace Online_Voting_System_Backend.Models
{
    public class Voter
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid(); // Create a unique id for each voter
        public string? Name { get; set; } // Name of the voter
        public required byte[] Image { get; set; } // Image to be used for auth
    }
}
