using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Voting_System_Backend.Models
{
    public class Election
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid AdminId { get; set; }
        [ForeignKey("AdminId")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
