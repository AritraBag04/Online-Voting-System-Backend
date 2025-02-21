namespace Online_Voting_System_Backend.Models
{
    public class Admin
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public required byte[] Image { get; set; }
    }
}
