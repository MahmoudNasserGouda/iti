using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class MainMenuController : Controller
    {
       
        public IActionResult MainMenu()
        {
            return View();
        }
    }
}
