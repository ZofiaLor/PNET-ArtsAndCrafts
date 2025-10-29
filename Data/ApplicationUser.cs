using ArtsAndCrafts.Models;
using Microsoft.AspNetCore.Identity;

namespace ArtsAndCrafts.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Pattern> CreatedPatterns { get; set; }
        public ICollection<PatternUser> BookmarkedPatterns { get; set; }
        public ICollection<ToolUser> BookmarkedTools { get; set; }
        public ICollection<YarnUser> BookmarkedYarns { get; set; }
    }

}
