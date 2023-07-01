using ConsumerMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerMVC.Controllers
{
    public class DepartmentController : Controller
    {
        HttpClient client = new HttpClient();
        string EndPoint = "http://localhost:5294/api/Department";

        public async Task<IActionResult> Index()
        {
           List<Department> Depts= await client.GetFromJsonAsync<List<Department>>(EndPoint);
            return View(Depts);
        }

        //waits for the same structure 
        public async Task<IActionResult> GetOne()
        {
          DeptEmp DeptEmpInfo= await client.GetFromJsonAsync<DeptEmp>("http://localhost:5294/api/Department/1");
            return View(DeptEmpInfo);
        }

        public async Task<IActionResult> AddDept()
        {
            Department Dept = new Department() { Name = "TestCons", Address = "text" };
           HttpResponseMessage Response=   await client.PostAsJsonAsync<Department>(EndPoint, Dept);
      
            if(Response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                Department Dept2 = Response.Content.ReadFromJsonAsync<Department>().Result;
                return View(Dept2);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}
