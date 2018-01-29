using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GummiBear.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace GummiBear.Controllers
{
    public class ReviewsController : Controller
    {
       private GummiBearContext db = new GummiBearContext();

       public IActionResult Index(int id)
        {
            Console.WriteLine("this is the index method " + id);
            return View(db.Reviews.Where(reviews => reviews.ProductId == id).ToList());
            //return View();
        }

        public IActionResult Create(int id)
        {
            // var thisReview = db.Reviews.FirstOrDefault(reviews => reviews.ReviewId == id);
            ViewBag.ProductId = id;
            Console.WriteLine("This is in the create form ############### " + ViewBag.ProductId);
            return View();
        }

        [HttpPost]
        public IActionResult Create(Review review)
        {
            Console.WriteLine("##########################" + review.ProductId);
            db.Reviews.Add(review);
            Console.WriteLine(review);
            db.SaveChanges();
            Console.WriteLine(review);
            return RedirectToAction("Index", "Products", new { area=""});
        }

 





    }
}
