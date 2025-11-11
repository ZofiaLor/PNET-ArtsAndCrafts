namespace ArtsAndCrafts.Models
{
    public class Tool : CraftObject
    {
        public string Material { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int Size { get; set; }
        public ICollection<Pattern> Patterns { get; set; }
    }
}
