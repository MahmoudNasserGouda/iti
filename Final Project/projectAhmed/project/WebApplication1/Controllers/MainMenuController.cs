using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class MainMenuController : Controller
    {
	
		IBookRepository book;
		ICategoryRepository category;
		public MainMenuController(ICategoryRepository _category, IBookRepository _book)
		{

			book = _book;
			category = _category;

		}
		public IActionResult MainMenu()
        {
			ViewBag.HorrorCategoryNumber = book.GetHorror().Count;
			ViewBag.SciFiCategoryNumber= book.GetSciFi().Count;
			ViewBag.AdventureCategoryNumber= book.GetAdventure().Count;
			ViewBag.TotalBooks= book.GetHorror().Count+book.GetSciFi().Count+book.GetAdventure().Count;	
            return View(book.GetAll());
        }
    }
}
