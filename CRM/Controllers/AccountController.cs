using CRM.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public IActionResult Register(Account account)
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    db.Accounts.Add(account);
                    db.SaveChanges();
                    return RedirectToAction("DisplayBugs", "Bug");
                }
            }
            catch (Exception ex)
            {
                
            }
            return View();
        }
    }
}
