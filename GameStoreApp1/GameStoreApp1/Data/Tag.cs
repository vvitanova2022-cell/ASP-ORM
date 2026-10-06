namespace GameStoreApp1.Data
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GameTag> GameTags { get; set; } = new List<GameTag>();
    }
}
