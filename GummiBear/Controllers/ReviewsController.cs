using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GummiBear.Models;

namespace GummiBear.Controllers
{
    public class ReviewsController : Controller
    {
        private GummiBearContext db = new GummiBearContext();
        public IActionResult NewReview()
        {
            return View(db.Reviews.Include(reviews => reviews.Product).ToList());
        }
        public IActionResult Details(int id)
        {
            var thisReview = db.Reviews.FirstOrDefault(reviews => reviews.ReviewId == id);
            return View(thisReview);
        }
        public IActionResult Create()
        {
            ViewBag.ProductId = new SelectList(db.Products, "ProductId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
            return RedirectToAction("NewReview");
        }

        /*public IActionResult Edit(int id)
        {
            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
            return View(thisItem);
        }
        [HttpPost]
        public IActionResult Edit(Item item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
            return View(thisItem);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
            db.Items.Remove(thisItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        } */
    }
}
