namespace Online_Voting_System_Backend.Models
{
    public class Party
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
