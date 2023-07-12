using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly IReportRepository _reportRepository;
        private IBookRepository _bookRepository;
        public DashBoardController(IReportRepository reportRepository, IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
            _reportRepository = reportRepository;
        }
        public async Task<IActionResult> DashBoard()
        {
            var report = await _reportRepository.ReturnReport();
            ViewBag.TopBooks =  _bookRepository.TopFiveRatedBooks();
            return View(report);
        }
    }
}
