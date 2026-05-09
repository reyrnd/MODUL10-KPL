namespace Modul10_103022400125
{
    public class Game
    {
        public int id { get; set; } = 0;
        public string Nama { get; set; } = "";
        public string Developer { get; set; } = "";
        public int TahunRilis { get; set; } = 0;

        public string Genre { get; set; } = "";
        public double Rating { get; set; } = 0;
        public string[] Platform { get; set; }
        public string[] Mode { get; set; }

        public bool IsOnline { get; set; }
        public int Harga { get; set; }

        public Game()
        {

        }
    }
}
