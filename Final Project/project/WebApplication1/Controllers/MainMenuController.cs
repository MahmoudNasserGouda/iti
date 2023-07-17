using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using WebApplication1.Models.Repositories;
using WebApplication1.Models.Objects;

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
			ViewBag.RomanceCategoryNumber= _book.GetByCategory(4).Result.Count;	
            return View(_book.GetAll().Result);
		}

		public IActionResult Community(bool? open)
		{
			const string path = @"community.json";
			var o = JsonConvert.DeserializeObject<Community>(System.IO.File.ReadAllText(path));
			if (open != null)
			{
				o.open = (bool)open;
				var json = JsonConvert.SerializeObject(o, Formatting.Indented);
				System.IO.File.WriteAllText(path, json);
			}
			ViewBag.Open = o.open;
			return View();
		}

		public IActionResult Announcement(Announcement? ann)
		{
			const string path = @"announcement.json";
			var o = JsonConvert.DeserializeObject<Announcement>(System.IO.File.ReadAllText(path));
			if ( ann != null )
			{
                if (ann.Head != null && ann.P1 != null && ann.P2 != null)
                {
					o.Head = ann.Head;
					o.P1 = ann.P1;
					o.P2 = ann.P2;
					var json = JsonConvert.SerializeObject(o, Formatting.Indented);
					System.IO.File.WriteAllText(path, json);
				}
                
			}
			return View(o);
		}
	}
}
