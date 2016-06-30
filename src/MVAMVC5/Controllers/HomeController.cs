using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVAMVC5.Models;

namespace MVAMVC5.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            //new git
            return View();
        }
        [HttpPost]
        public  ActionResult About(person pin)
        {
            return View(pin);
        }
        [HttpGet]
        public IActionResult About()
        {
            ViewData["Message"] = "Here is a person.";
            var p = new person() {
                FirstName = "hardik",
                LastName = "chudasama",
                BirthDate = new DateTime(1987, 4, 8)
            };
            return View(p);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
