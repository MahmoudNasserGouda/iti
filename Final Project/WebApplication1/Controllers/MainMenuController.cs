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
			ViewBag.HorrorCategoryNumber = _book.GetByCategory(1).Result.Count;
			ViewBag.SciFiCategoryNumber= _book.GetByCategory(2).Result.Count;
			ViewBag.AdventureCategoryNumber= _book.GetByCategory(3).Result.Count;
			ViewBag.TotalBooks= _book.GetAll().Result.Count;	
            return View(_book.GetAll().Result);
        }
    }
}
