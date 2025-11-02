using ArtsAndCrafts.Data;

namespace ArtsAndCrafts.Models
{
    public class ToolUser
    {
        public bool IsOwned { get; set; }
        public int ToolId { get; set; }
        public string UserId { get; set; }
        public Tool Tool { get; set; }
        public ApplicationUser User { get; set; }
    }
}
