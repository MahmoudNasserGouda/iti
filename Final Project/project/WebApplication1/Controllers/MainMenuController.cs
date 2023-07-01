using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class MainMenuController : Controller
    {
	
		private IBookRepository _book;
		private ICategoryRepository _category;
		public MainMenuController(ICategoryRepository category, IBookRepository book)
		{

			_book = book;
			_category = category;

		}
		public IActionResult MainMenu()
        {
			ViewBag.HorrorCategoryNumber = _book.GetHorror().Count;
			ViewBag.SciFiCategoryNumber= _book.GetSciFi().Count;
			ViewBag.AdventureCategoryNumber= _book.GetAdventure().Count;
			ViewBag.TotalBooks= _book.GetHorror().Count+_book.GetSciFi().Count+_book.GetAdventure().Count;	
            return View(_book.GetAll().Result);
        }
    }
}
