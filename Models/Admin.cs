using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Voting_System_Backend.Models
{
    public class Admin
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
