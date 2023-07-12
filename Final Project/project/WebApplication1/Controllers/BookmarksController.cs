using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;
using WebApplication1.Models.Repositories;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebApplication1.Controllers
{
	[Authorize]
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
        public async Task<IActionResult> List(BookmarkStatus status)
        {
            List<Book> books = new List<Book>();
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    books = await _userRepository.GetBookmarkedBooks(user.Id, status);
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

        [HttpPost]
        public async Task<IActionResult> Status(int Id, BookmarkStatus status)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    await _userRepository.SetBookmarkStatus(user.Id, Id, status);
                }
            }
            return Json(new { success = true });
        }
    }
}
