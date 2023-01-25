using CRM.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class BugController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //httpget
        public IActionResult CreateBug()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBug(Bug bug)
        {
            return View();
        }

        public IActionResult UpdateBug()
        {
            return View();
        }

        public IActionResult DeleteBug()
        {
            return View();
        }
    }
}
