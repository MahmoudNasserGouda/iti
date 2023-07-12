using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;
        private UserManager<User> _userManager;
        private IUserReviewRepository _userReviewRepository;
        private IReviewRepository _reviewRepository;
        private IChapterRepository _chapterRepository;
        private IUserRepository _userRepository;

        public BookController(IBookRepository bookRepository, IUserReviewRepository userReviewRepository, UserManager<User> userManager, IReviewRepository reviewRepository, IChapterRepository chapterRepository, IUserRepository userRepository)
        {
            _bookRepository = bookRepository;
            _userReviewRepository = userReviewRepository;
            _userManager = userManager;
            _reviewRepository = reviewRepository;
            _chapterRepository = chapterRepository;
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int Id)
        {
            await _bookRepository.CalculateRating(Id);
            Book book = await _bookRepository.GetById(Id);
            ViewBag.chaptersCount = _chapterRepository.GetAll(Id).Result.Count();
            int reviews = await _bookRepository.GetReviewsCount(Id);
            ViewBag.reviews = reviews;
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Bookmark(int Id)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    await _userRepository.BookmarkBook(user.Id, Id);
                    return Json(new { success = true });
                }
            }
            return RedirectToAction("Login","Account");
        }

        [HttpPost]
        public async Task<IActionResult> UnBookmark(int Id)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    await _userRepository.UnBookmarkBook(user.Id, Id);
                    return Json(new { success = true });
                }
            }
            throw new ArgumentNullException(nameof(User));
        }

    }
}
