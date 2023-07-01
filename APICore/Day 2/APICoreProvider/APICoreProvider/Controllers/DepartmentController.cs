using APICoreProvider.DTO;
using APICoreProvider.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //DeptwithDTO
        [HttpGet("{id}", Name = "GetOneDept")]
        public IActionResult GetDeptWithEmpNames(int id)
        {
            DeptWithListEmpInfo DeptEmpDTO = new DeptWithListEmpInfo();
            Department Dept = context.Departments.Include(e => e.Employees).FirstOrDefault(d => d.ID == id);
            DeptEmpDTO.DeptName = Dept.Name;
            DeptEmpDTO.DeptId = Dept.ID;

            foreach (var item in Dept.Employees)
            {
                DeptEmpDTO.EmployeeNames.Add(item.Name);
            }

            return Ok(DeptEmpDTO);


        }



        //[HttpGet] //URL : /api/Department/id
        //[Route("{id:int}",Name="GetOneDept")]
        //public ActionResult GetOneDept(int id)
        //{
        //   Department Dept =context.Departments.Include(e=>e.Employees).Where(d => d.ID == id).FirstOrDefault();
        //    if(Dept !=null)
        //    {
        //        return Ok(Dept);
        //    }
        //    else
        //        return NotFound();
        //}

        [HttpGet] //URL : /api/Department/id
        [Route("{name:alpha}")] //--
        public ActionResult GetOneDept(string name)
        {
            return Ok(context.Departments.Where(d => d.Name == name).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult AddDept(Department Dept)
        {
            if (ModelState.IsValid)
            {
                context.Departments.Add(Dept);
                context.SaveChanges();
                //return Ok("Added");
                //return Created("http://localhost:5294/api/Department/" + Dept.ID, Dept);
                string location = Url.Link("GetOneDept", new { id = Dept.ID });
                return Created(location, Dept);
            }
            else
            {
                return BadRequest("Not Vaild");
            }
        }

        //Param Binding
        [HttpPut]
        public IActionResult UpdateDept([FromBody]int id, [FromHeader] Department Dept)
        {
            Department UpdateDept = context.Departments.FirstOrDefault(d => d.ID == Dept.ID);
            UpdateDept.Name = "TestPut";
            context.SaveChanges();
            return Ok(UpdateDept);

        }

        




        /*
         * [FromBody] ==> Body Requst
         * [FromHeader] ==> URL
         * [FromQuery] ==> As Query String
         * [FromRoute] ==> URL as Segment
         * [FromService] ==> From another Service
         * [FromForm] ==> from submit form
        **/
    }
}
