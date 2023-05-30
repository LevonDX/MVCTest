using Microsoft.AspNetCore.Mvc;
using MVCTest.Models;
using System.Diagnostics;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Action
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Hello()
        {
            string name = "john";

            ViewData["name"] = name;
            ViewBag.Name = name;


            TempData["name"] = name;

            return View(model: name);
        }
    }
}