using ArtsAndCrafts.Data;

namespace ArtsAndCrafts.Models
{
    public class Pattern : CraftObject
    {
        public string Content { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastEditDate { get; set; }

        public string AuthorId { get; set; }

        public ApplicationUser Author { get; set; }
        public ICollection<Yarn> Yarns { get; set; }
        public ICollection<Tool> Tools { get; set; }
    }
}
