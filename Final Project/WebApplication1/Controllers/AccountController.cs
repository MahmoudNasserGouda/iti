using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Entities;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
       private readonly UserManager<User> usermanager;
        private readonly SignInManager<User> signinmanager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            usermanager = userManager;
            signinmanager = signInManager; 
        }
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(UserViewModel myvmuser) 
        {
            if(ModelState.IsValid) 
            { 
                User myuser = new User();
                myuser.UserName = myvmuser.UserName;
                myuser.Email= myvmuser.Email;
                myuser.PhoneNumber = myvmuser.PhoneNumber;
                myuser.PasswordHash = myvmuser.Password;
              var res=  await usermanager.CreateAsync(myuser,myvmuser.Password); // have to await it
                if(res.Succeeded)
                {
                  await signinmanager.SignInAsync(myuser,false);
                    return RedirectToAction("MainMenu", "MainMenu");
                }else
                {
                    foreach (var item in res.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
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
            if(ModelState.IsValid)
            {
             User myuser=   await usermanager.FindByNameAsync(user.UserName); 

                if(myuser !=null)
                {
                 var res=  await signinmanager.CheckPasswordSignInAsync(myuser, user.Password, false);
                    if(res.Succeeded)
                    {
                        await signinmanager.SignInAsync(myuser,user.IsPersisted);
						return RedirectToAction("MainMenu", "MainMenu");
					}
                    else
                    {
                        ModelState.AddModelError("Error:", "Wrong UserName or Passowrd");
                        return View();
                    }
                }
                else { 
                    ModelState.AddModelError("Error", "Wrong UserName or Passowrd");
                    return View();
                }
               

            }
            else { 
                ModelState.AddModelError("Error", "Wrong UserName or Passowrd");
              
            }

            return View();

        }

        public async Task<IActionResult> LogOut()
        {
            await signinmanager.SignOutAsync();


            return RedirectToAction("Registration");
           
        }

    }

 

}
