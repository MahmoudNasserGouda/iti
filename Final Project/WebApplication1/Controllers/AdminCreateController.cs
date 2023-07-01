using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminCreateController : Controller
    {
        private readonly UserManager<User> usermanager;
        private readonly SignInManager<User> signinmanager;

        public AdminCreateController(UserManager<User> _usermanager, SignInManager<User> _signinmanager)
        {
            usermanager = _usermanager;
            signinmanager = _signinmanager;
        }
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAdmin(UserViewModel uservm)
        {
            if(ModelState.IsValid) 
            {
                User user = new User(); 
                user.UserName = uservm.UserName;
                user.PhoneNumber = uservm.PhoneNumber;
                user.Email = uservm.Email;
                user.PasswordHash = uservm.Password;

              var res=  await usermanager.CreateAsync(user,uservm.Password);
                if(res.Succeeded) 
                {
                    // must be created

                   var result = await  usermanager.AddToRoleAsync(user,"Admin");
                    if(result.Succeeded) 
                    {
                        await signinmanager.SignInAsync(user, false);
                    }
                    else
                    {
                        ModelState.AddModelError("","Role does not exist");
                    }


                }
                else
                {
                    foreach (var item in res.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
              
            }
            return View(uservm);
        }

    }
}
