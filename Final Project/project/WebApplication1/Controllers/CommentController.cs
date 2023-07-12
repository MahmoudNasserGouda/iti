using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Data;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
    public class CommentController : Controller
    {
        private IChapterRepository _chapterRepository;
        private IBookRepository _bookRepository;
        private ICommentRepository _commentRepository;
        private IUserCommentRepository _userCommentRepository;
        private UserManager<User> _userManager;
        public CommentController(IChapterRepository chapterRepository, UserManager<User> userManager, IBookRepository bookRepository, ICommentRepository commentRepository, IUserCommentRepository userCommentRepository)
        {
            _chapterRepository = chapterRepository;
            _userManager = userManager;
            _bookRepository = bookRepository;
            _commentRepository = commentRepository;
            _userCommentRepository = userCommentRepository;
		}

		[Authorize]
		[HttpGet]
        public async Task<IActionResult> Comments(int Id)
        {
            List<Comment> comments = await _commentRepository.GetAll(Id);
            return View(comments);
        }

		[Authorize(Roles = "Admin")]
		[HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            await _commentRepository.Delete(Id);
            return Json(new { success = true });
        }

		[Authorize(Roles = "PremiumUser, Admin")]
		[HttpGet]
        public async Task<IActionResult> Comment()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    return View(new Comment());
                }
            }
            return RedirectToAction("Login", "Account");
        }

		[Authorize(Roles = "PremiumUser, Admin")]
		[HttpPost]
        public async Task<IActionResult> Comment(Comment comment)
        {
            if (comment == null || comment.Text == null)
            {
				ModelState.AddModelError(nameof(comment.Text), "*you can't write empty comment");
				return View(comment);
			}
            var filter = new ProfanityFilter.ProfanityFilter();
            var swearList = filter.DetectAllProfanities(comment.Text);
            if (swearList.Count > 0)
            {
                ModelState.AddModelError(nameof(comment.Text), "*you can't write profane words like (" + String.Join(", ", swearList) + ").");
                return View(comment);
            }
            await _commentRepository.AddComment(comment);
            return Json(new { success = true });
        }

		[Authorize(Roles = "PremiumUser, Admin")]
		[HttpPost]
        public async Task<IActionResult> UpVote(int commentId, int vote)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    int currentVote = 0;
                    UserComment userComment = await _userCommentRepository.GetUserCommentAsync(user.Id, commentId);
                    if (userComment != null)
                    {
                        currentVote = userComment.Likes;
                    }
                    await _userCommentRepository.SetUserCommentAsync(user.Id, commentId, vote);
                    for (int i = 0; i < (vote - currentVote); i++)
                    {
                        await _commentRepository.UpVote(commentId);
                    }
                }
            }
            return Json(new { success = true });
        }

		[Authorize(Roles = "PremiumUser, Admin")]
		[HttpPost]
        public async Task<IActionResult> DownVote(int commentId, int vote)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                User user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    int currentVote = 0;
                    UserComment userComment = await _userCommentRepository.GetUserCommentAsync(user.Id, commentId);
                    if (userComment != null)
                    {
                        currentVote = userComment.Likes;
                    }
                    await _userCommentRepository.SetUserCommentAsync(user.Id, commentId, vote);
                    for (int i = 0; i < Math.Abs(vote - currentVote); i++)
                    {
                        await _commentRepository.DownVote(commentId);
                    }
                }
            }
            return Json(new { success = true });
        }

    }
}
