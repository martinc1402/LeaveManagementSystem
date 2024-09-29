using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1991, 02, 14)
            };
            return View(data);
        }

    }
}
