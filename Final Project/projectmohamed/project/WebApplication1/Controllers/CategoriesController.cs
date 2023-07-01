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
    }
}
