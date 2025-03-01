using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Voting_System_Backend.Models
{
    [Keyless]
    public class Election_Result
    {
        public Guid ElectionId {  get; set; }
        [ForeignKey("ElectionId")]
        public Election Election { get; set; }
        public Guid CandidateId { get; set; }
        [ForeignKey("CandidateId")]
        public Candidate Candidate { get; set; }
        public int Votes { get; set; }
    }
}
