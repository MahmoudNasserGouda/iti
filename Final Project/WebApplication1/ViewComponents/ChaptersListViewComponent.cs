using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.ViewComponents
{
    public class ChaptersListViewComponent : ViewComponent
    {
        private IChapterRepository _chapterRepository;

        public ChaptersListViewComponent(IChapterRepository chapterRepository)
        {
            _chapterRepository = chapterRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            List<Chapter> chapters = await _chapterRepository.GetAll(id);
            return View("Default", chapters);
        }
    }
}
