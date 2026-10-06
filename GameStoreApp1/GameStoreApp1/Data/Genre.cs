using System.Numerics;
using System.Security.Principal;

namespace GameStoreApp1.Data
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
