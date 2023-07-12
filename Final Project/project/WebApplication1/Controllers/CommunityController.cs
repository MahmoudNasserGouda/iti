using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CommunityController : Controller
    {
        [Authorize(Roles = "PremiumUser, Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
