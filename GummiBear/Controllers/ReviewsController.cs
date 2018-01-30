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
        private IReviewRepository reviewRepo;

        public ReviewsController(IReviewRepository repo = null)
        {
            if (repo == null)
            {
                this.reviewRepo = new EFReviewRepository();
            }
            else
            {
                this.reviewRepo = repo;
            }
        }


       public IActionResult Index(int id)
        {
            Console.WriteLine("this is the index method " + id);
            return View(reviewRepo.Reviews.Where(reviews => reviews.ProductId == id).ToList());
            //return View();
        }

        //public ViewResult Index()
        //{
        //    // Updated:
        //    return View(reviewRepo.Reviews.ToList());
        //}

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
            //reviewRepo.Reviews.Add(review);
            Console.WriteLine(review);
            reviewRepo.Save(review);
            Console.WriteLine(review);
            return RedirectToAction("Index", "Products", new { area=""});
        }

 





    }
}
