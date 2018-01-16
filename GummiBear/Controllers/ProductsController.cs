﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBear.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBear.Controllers
{
    public class ProductsController : Controller
    {
        // GET: /<controller>/
        private GummiBearContext db = new GummiBearContext();
        public IActionResult Index()
        {
            List<Product> model = db.Products.ToList();
            return View();
        }
    }
}
