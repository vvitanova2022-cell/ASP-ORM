namespace GameStoreApp1.Data
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<GameTag> GameTags { get; set; }
            = new List<GameTag>();

        public ICollection<Purchase> Purchases { get; set; }
            = new List<Purchase>();
    }
}
