using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Voting_System_Backend.Models
{
    public class Candidate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public Guid PartyId { get; set; } // Foreign key from Party
        [ForeignKey("PartyId")]
        public Party Party { get; set; }
    }
}
