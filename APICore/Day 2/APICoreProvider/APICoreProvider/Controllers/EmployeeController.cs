using APICoreProvider.DTO;
using APICoreProvider.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICoreProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ITIEntity context;
        public EmployeeController(ITIEntity context)
        {
            this.context = context;
        }
        [HttpGet]
       public IActionResult GetAllEmp()
        {
            return Ok(context.Employees.Include(d => d.Department).ToList());
        }

        //[HttpGet("{id}")]
        //public IActionResult GetOneEmp(int id)
        //{
        //    return Ok(context.Employees.Include(d => d.Department).FirstOrDefault(e => e.ID == id));
        //}

        [HttpGet("{id}")]
        public IActionResult GetEmpWithDept(int id )
        {
            EmployeeWithDeptInfo EmpWithDeptDTO = new EmployeeWithDeptInfo();
            Employee Emp = context.Employees.Include(d=>d.Department).FirstOrDefault(e => e.ID == id);

            EmpWithDeptDTO.DeptName = Emp.Department.Name;
            EmpWithDeptDTO.EmpName = Emp.Name;

            return Ok(EmpWithDeptDTO);

        }
    }
}
