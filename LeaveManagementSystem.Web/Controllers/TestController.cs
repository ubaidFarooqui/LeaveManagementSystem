using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Ubaid Ahmed Farooqui",
                DateOfBirth = new DateTime(1987,12,09)
            
            };
            return View(data);
        }
    }
}
