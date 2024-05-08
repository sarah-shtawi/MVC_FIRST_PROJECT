using FirstProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Employees = context.Employees.ToList();
            return View("Index", Employees);
        }
    }
}
