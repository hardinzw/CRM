using CRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CRM.Controllers
{
    public class BugController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddBug()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBug(Bug bug)
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    db.Bug.Add(bug);
                    db.SaveChanges();
                    return RedirectToAction("DisplayBugs");
                }

            }
            catch (Exception ex)
            {
                return View();
            }
            //try
            //{
            //    _ctx.Add(bug);
            //    _ctx.SaveChanges();
            //    TempData["message"] = "Bug recorded.";
            //    return RedirectToAction("Index");
            //} 
            //catch (Exception ex)
            //{
            //    TempData["message"] = ex.Message;
            //    return View();
            //}
        }

        [HttpGet]
        public IActionResult EditBug(int id)
        {
            using (var db = new DatabaseContext())
            {
                var bug = db.Bug.Find(id);
                return View(bug);
            }
        }

        [HttpPost]
        public IActionResult EditBug(Bug bug)
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    db.Bug.Update(bug);
                    db.SaveChanges();
                    return RedirectToAction("DisplayBugs");
                }

            }
            catch (Exception ex)
            {
                TempData["message"] = "Could not update.";
                return View();
            }
            //try
            //{
            //    _ctx.Add(bug);
            //    _ctx.SaveChanges();
            //    TempData["message"] = "Bug recorded.";
            //    return RedirectToAction("Index");
            //} 
            //catch (Exception ex)
            //{
            //    TempData["message"] = ex.Message;
            //    return View();
            //}
        }

        public IActionResult DeleteBug(int id)
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    var bug = db.Bug.Find(id);
                    if (bug != null)
                    {
                        db.Bug.Remove(bug);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("DisplayBugs");
        }

        public IActionResult DisplayBugs()
        {
            using (var db = new DatabaseContext())
            {
                var bugs = db.Bug.ToList();
                return View(bugs);
            }
        }
    }
}
