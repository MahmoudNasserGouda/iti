using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> rolemanager;
 
        public RoleController(RoleManager<IdentityRole> _rolemanager)
        {
            rolemanager = _rolemanager;
        
            
        }
        public  IActionResult AddRole()
        {
            return View();
        }
        // receive view model
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleAddVM rolevm)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityrole = new IdentityRole();
                identityrole.Name = rolevm.Name;
                var res = await rolemanager.CreateAsync(identityrole);
                if(res.Succeeded) 
                { 
                    return View();
                }
                else 
                {
                   
                    ModelState.AddModelError("", "Please enter a valid role name");
                }

            }
            return View(rolevm);
        }



    }
}
