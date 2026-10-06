namespace GameStoreApp1.Data
{
    public class Card
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Cvc { get; set; }
        public  string Type { get; set; }
        public int UserId { get; set; }
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
