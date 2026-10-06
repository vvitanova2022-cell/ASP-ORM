namespace GameStoreApp1.Data
{
    public class GameTag
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; } = null!;

        public int TagId { get; set; }

        public Tag Tag { get; set; } = null!;

    }
}
