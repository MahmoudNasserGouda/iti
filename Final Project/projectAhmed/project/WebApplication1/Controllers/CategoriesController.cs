using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        IBookRepository book;
        ICategoryRepository category;
        public CategoriesController(ICategoryRepository _category, IBookRepository _book)
        {

            book = _book;
            category = _category;

        }
        public IActionResult Categories()
        {
           
            return View(book.GetAll());
        }

        public IActionResult GetHorror()
        {

            return PartialView("_BookList",book.GetHorror());
        }

        public IActionResult GetSciFi()
        {

            return PartialView("_BookList", book.GetSciFi());
        }
        public IActionResult GetAdventure()
        {

            return PartialView("_BookList", book.GetAdventure());
        }
        public IActionResult GetSearchResult(string SearchString)
        {

            return PartialView("_BookList", book.GetSearchResult(SearchString));
        }
    }
}
