using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.Enums;
using WebApplication1.Models.Repositories;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class PaymentController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;
        private readonly IReportRepository _reportRepository;
        private readonly SignInManager<User> _signinmanager;
        public PaymentController(UserManager<User> userManager, IUserSubscriptionRepository userSubscriptionRepository, IReportRepository reportRepository, SignInManager<User> signinmanager)
        {
            _userManager = userManager;
            _userSubscriptionRepository = userSubscriptionRepository;
            _reportRepository = reportRepository;
            _signinmanager = signinmanager;
        }
        public IActionResult Payment(Subscription subscription)
        {     
            return View(subscription);
        }
        public async Task<IActionResult> CompletePayment(int months)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            await _userManager.AddToRoleAsync(user, "PremiumUser");

            // Create a subscription for the user

            var subscription = new UserSubscription
            {
                UserId = user.Id,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddMonths(months), //  TODO: Fix this
                Status = SubscriptionStatus.Active
            };
            if(months== 6) 
            {
                _reportRepository.AddBetaSubMember(1);
            } else if(months == 8)
            {
                _reportRepository.AddAlphaSubMember(1);
            }
            else //10
            {
                _reportRepository.AddOmegaSubMember(1);
            }


            await _userSubscriptionRepository.AddUserSubscriptionAsync(subscription);
            User myuser = await _userManager.FindByNameAsync(user.UserName);
            await _signinmanager.SignOutAsync();
            await _signinmanager.SignInAsync(myuser, false);
            return RedirectToAction("Categories", "Categories");
        }
    }
}
