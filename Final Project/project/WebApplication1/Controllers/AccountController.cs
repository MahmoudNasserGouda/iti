using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.ViewModels;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> usermanager;
        private readonly SignInManager<User> signinmanager;
        private readonly IEmailService _emailService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailService emailService)
        {
            usermanager = userManager;
            signinmanager = signInManager;
            _emailService = emailService;
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(UserViewModel myvmuser)
        {
            if (ModelState.IsValid)
            {
                User myuser = new User();
                myuser.UserName = myvmuser.UserName;
                myuser.Email = myvmuser.Email;
                myuser.PhoneNumber = myvmuser.PhoneNumber;
                myuser.PasswordHash = myvmuser.Password;
                var res = await usermanager.CreateAsync(myuser, myvmuser.Password); // have to await it
                if (res.Succeeded)
                {
                    await signinmanager.SignInAsync(myuser, false);
                    return RedirectToAction("MainMenu", "MainMenu");
                }
                else
                {
                    foreach (var item in res.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }
            }
            return View(myvmuser);
        }
        public IActionResult Login(/*string ReturnUrl= "~/Game/MainMenu"*/)
        {
            //ViewBag.ReturnUrl = "NULL";
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserVM user /*,string ReturnUrl = "~/Game/MainMenu"*/)
        {
            if (ModelState.IsValid)
            {
                User myuser = await usermanager.FindByNameAsync(user.UserName);

                if (myuser != null)
                {
                    var res = await signinmanager.CheckPasswordSignInAsync(myuser, user.Password, false);
                    if (res.Succeeded)
                    {
                        await signinmanager.SignInAsync(myuser, user.IsPersisted);
                        return RedirectToAction("MainMenu", "MainMenu");
                    }
                    else
                    {
                        ModelState.AddModelError("Error:", "Wrong UserName or Passowrd");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("Error", "Wrong UserName or Passowrd");
                    return View();
                }


            }
            else
            {
                ModelState.AddModelError("Error", "Wrong UserName or Passowrd");

            }

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> SendResetPasswordEmail(ResetPasswordEmailVM emailVM)
        {
            var user = await usermanager.FindByEmailAsync(emailVM.Email);
            if (user != null)
            {
                var token = Guid.NewGuid().ToString();
                user.ResetPasswordToken = token;
                user.ResetPasswordTokenExpirationDate = DateTime.UtcNow.AddHours(24);
                user.IsResetTokenUsed = false;
                await usermanager.UpdateAsync(user);
                var body = $"Here's your reset password link: https://localhost:7155/Account/VerifyResetPasswordToken?userEmail={user.Email}&token={token}";
                await _emailService.SendEmailAsync("Reset Password link", body, user.Email, user.UserName);
            }
            return View("Login");
        }

        [HttpGet]
        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }


        public async Task<IActionResult> VerifyResetPasswordToken([FromQuery] string userEmail, [FromQuery] string token)
        {
            var user = await usermanager.FindByEmailAsync(userEmail);
            if (user != null)
            {
                if (user.ResetPasswordToken == token && user.IsResetTokenUsed == false)
                {
                    var viewModel = new ResetPasswordVM()
                    {
                        Email = userEmail
                    };
                    return View("VerifyResetPasswordToken", viewModel);
                }
            }
            return View("Login");
        }

        public async Task<IActionResult> ResetUserPassword(ResetPasswordVM resetPasswordModel)
        {
            var user = await usermanager.FindByEmailAsync(resetPasswordModel.Email);
            if (user != null)
            {
                user.PasswordHash = usermanager.PasswordHasher.HashPassword(user, resetPasswordModel.Password);
                user.IsResetTokenUsed = true;
                await usermanager.UpdateAsync(user);
            }
            return View("Login");
        }

        public async Task<IActionResult> LogOut()
        {
            await signinmanager.SignOutAsync();


            return RedirectToAction("Registration");

        }

    }



}
