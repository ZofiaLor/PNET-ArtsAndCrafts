using ArtsAndCrafts.Data;

namespace ArtsAndCrafts.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public int CraftObjectId { get; set; }
        public int? ParentId { get; set; }

        public ApplicationUser Author { get; set; }
        public CraftObject CraftObject { get; set; }
        public Comment? Parent {  get; set; }
        public ICollection<Comment> Children { get; set; }
    }
}
