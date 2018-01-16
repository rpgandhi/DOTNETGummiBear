using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GummiBear.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            ViewData["Message"] = "Our inventory is growing. Stay tuned for more products!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "We'd love to hear from you!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
