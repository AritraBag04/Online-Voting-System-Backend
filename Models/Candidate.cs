namespace Online_Voting_System_Backend.Models
{
    public class Candidate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Party { get; set; }
        public byte[] Image { get; set; }
    }
}
