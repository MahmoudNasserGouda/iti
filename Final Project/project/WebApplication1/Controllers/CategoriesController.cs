using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    [Authorize]
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
            ViewBag.Categories = category.GetAll().Result;
            return View(book.GetAll().Result);
        }

        //public IActionResult GetHorror()
        //{

        //    return PartialView("_BookList",book.GetHorror());
        //}

        //public IActionResult GetSciFi()
        //{

        //    return PartialView("_BookList", book.GetSciFi());
        //}
        //public IActionResult GetAdventure()
        //{

        //    return PartialView("_BookList", book.GetAdventure());
        //}

        [HttpGet]
        public async Task<IActionResult> GetByCategory(int categoryId)
        {
            List<Book> books = await book.GetByCategory(categoryId);

            return PartialView("_BookList", books);
		}

        [HttpGet]
        public async Task<IActionResult> GetSearchResult(int categoryId, string SearchString)
        {
            List<Book> books = await book.GetSearchResult(categoryId, SearchString);
            return PartialView("_BookList", books);
        }

        public async Task<IActionResult> Delete(int ID)
        {
            await book.DeleteBook(ID);
            return Json(new { success = true });
        }
    }
}
