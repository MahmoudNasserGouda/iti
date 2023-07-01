using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class GameController : Controller
    {
        IGameRepository game;
        ISectionRepository section;
        public GameController(ISectionRepository _section, IGameRepository _game)
        {

            game = _game;
            section = _section; 

        }
        public IActionResult MainMenu()
        {
            return View();
        }
    }
}
