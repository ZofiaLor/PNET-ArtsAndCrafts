using ArtsAndCrafts.Data;

namespace ArtsAndCrafts.Models
{
    public class PatternUser
    {
        public bool IsDone { get; set; }
        public bool IsLiked { get; set; }
        public int PatternId { get; set; }
        public int UserId { get; set; }

        public Pattern Pattern { get; set; }
        public ApplicationUser User { get; set; }
    }
}
