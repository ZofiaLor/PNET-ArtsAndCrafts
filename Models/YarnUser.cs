using ArtsAndCrafts.Data;

namespace ArtsAndCrafts.Models
{
    public class YarnUser
    {
        public bool IsOwned { get; set; }
        public int YarnId { get; set; }
        public string UserId { get; set; }

        public Yarn Yarn { get; set; }
        public ApplicationUser User { get; set; }
    }
}
