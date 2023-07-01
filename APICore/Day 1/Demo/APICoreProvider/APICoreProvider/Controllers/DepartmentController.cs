using APICoreProvider.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace APICoreProvider.Controllers
{
    [Route("api/[controller]")] // Verb: /api/Department
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ITIEntity context;
        public DepartmentController(ITIEntity context)
        {
            this.context = context;
        }

        //URL=> /api/Department 
        [HttpGet]
        public ActionResult GetAllDept()
        {
            // return Ok(); //Status Code 
            return Ok(context.Departments.ToList());
        }
        [HttpGet] //URL : /api/Department/id
        [Route("{id:int}")]
        public ActionResult GetOneDept(int id)
        {
            return Ok(context.Departments.Where(d => d.ID == id));
        }

        [HttpGet] //URL : /api/Department/id
        [Route("{name:alpha}")]
        public ActionResult GetOneDept(string name)
        {
            return Ok(context.Departments.Where(d => d.Name == name));
        }

        [HttpPost]
        public ActionResult AddDept(Department Dept)
        {
            if(ModelState.IsValid ==true)
            {
                context.Departments.Add(Dept);
                context.SaveChanges();

                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }



    }
}
