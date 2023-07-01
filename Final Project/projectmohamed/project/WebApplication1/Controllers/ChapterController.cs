using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class ChapterController : Controller
    {
		//BookStoreContext context = new BookStoreContext();

      private  IChapterRepository _chapterRepository;
        public ChapterController(IChapterRepository chapterRepository)
        {

			_chapterRepository = chapterRepository;
        }
        public async Task< IActionResult> Ind(int id )
        {
            Chapter chapter = await _chapterRepository.GetById(id);


            return View(chapter);
        }
    }
}


//Department de = context.Departments.Where(d => d.Dept_Id == Id).FirstOrDefault();
