using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebApplication1.Controllers
{
    public class BookmarksController : Controller
    {
        private UserManager<User> _userManager;
        private IUserRepository _userRepository;

        public BookmarksController(IUserRepository userRepository, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            List<Book> books = new List<Book>();
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    books = await _userRepository.GetBookmarkedBooks(user.Id);
                    return View(books);
                }
            }
            return View(books);
        }

        [HttpPost]
        public async Task<IActionResult> Remove(int Id)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    await _userRepository.UnBookmarkBook(user.Id, Id);
                }
            }
            return Json(new { success = true });
        }
    }
}
