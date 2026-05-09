using Microsoft.AspNetCore.Mvc;

namespace Modul10_103022400125.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        private static List<Game> _listGame = new()
        {
            new Game {id = 1, Nama = "Valorant", Developer = "Riot Games", TahunRilis = 2020, Genre = "FPS", Rating = 8.5, Platform = new string[] {"PC"}, Mode = new string[] {"Multiplayer"}, IsOnline = true, Harga = 0 },
            new Game {id = 2, Nama = "GTA V", Developer = "Christopher Nolan", TahunRilis = 2013, Genre = "Open World", Rating = 9.5, Platform = new string[] {"PC", "PS4", "PS5", "XBOX"}, Mode = new string[] { "SinglePlayer", "Multiplayer" }, IsOnline = true, Harga = 300000 },
            new Game {id = 3, Nama = "The Witcher 3", Developer = "CD Projekt Red", TahunRilis = 2015, Genre = "FPS", Rating = 9.7, Platform = new string[] {"PC", "PS4", "PS5", "XBOX"}, Mode = new string[] {"SinglePlayer"}, IsOnline = false, Harga = 250000 }
        };

        [HttpGet]
        public ActionResult <List<Game>> Get()
        {
            return _listGame;
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetById(int id)
        {
            return _listGame[id - 1];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Game filmBaru)
        {
            _listGame.Add(filmBaru);
            return Ok("Game berhasil ditambahkan!");
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] Game updatedGame)
        {
            _listGame[id-1] = updatedGame;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var filmDihapus = _listGame[id - 1];
            _listGame.RemoveAt(id - 1);

            return Ok($"Game pada index {id} berhasil dihapus!");
        }
    }
}
