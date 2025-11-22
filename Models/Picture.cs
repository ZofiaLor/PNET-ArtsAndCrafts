namespace ArtsAndCrafts.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? Order { get; set; }

        public int CraftObjectId { get; set; }
        public CraftObject CraftObject { get; set; }
    }
}
