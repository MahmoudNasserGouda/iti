using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        HttpClient client = new HttpClient();
        string EndPoint = "http://localhost:5222/api/Employees";

        public async Task<IActionResult> Index()
        {
            List<Employee> employees = await client.GetFromJsonAsync<List<Employee>>(EndPoint);
            return View(employees);
        }

        public async Task<IActionResult> Details(int id)
        {
            Employee employee = await client.GetFromJsonAsync<Employee>(EndPoint + "/" + id);
            return View(employee);
        }

        public async Task<IActionResult> Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            await client.PostAsJsonAsync<Employee>(EndPoint, employee);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await client.DeleteAsync(EndPoint + "/" + id);
            return RedirectToAction("Index");
        }

    }
}
