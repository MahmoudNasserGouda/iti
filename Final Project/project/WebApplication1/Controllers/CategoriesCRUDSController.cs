using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
	[Authorize(Roles = "Admin")]
	public class CategoriesCRUDSController : Controller
    {
        IBookRepository book;
        ICategoryRepository category;
        public CategoriesCRUDSController(ICategoryRepository _category, IBookRepository _book)
        {

            book = _book;
            category = _category;

        }
        public IActionResult Update(int ID)
        {
            ViewBag.Category = category.GetAll().Result;
            ViewBag.Book  = book.GetAll().Result;    
            return View(book.GetById(ID).Result);
        }

        public IActionResult Updated(int Id,Book updatedbook)
        {
             book.UpdateBook( Id, updatedbook);
             return RedirectToRoute("Categories", new { action = "Categories" });

        }

        public IActionResult AddBook()
        {
            ViewBag.Category = category.GetAll().Result;
            ViewBag.Book = book.GetAll().Result;
            return View();
        }
        public IActionResult AddBookSave(Book booksaved)
        {
             book.SaveBook(booksaved);
             return RedirectToRoute("Categories", new { action = "Categories" });
        }
   


    }
}
