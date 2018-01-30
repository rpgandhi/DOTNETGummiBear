using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBear.Models;
using Microsoft.EntityFrameworkCore;

namespace GummiBear.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepo;

        public ProductsController(IProductRepository repo = null
        {
            if(repo == null)
            {
                this.productRepo = new EFProductRepository();
            }
            else
            {
                this.productRepo = repo;
            }

        public ViewResult Index()
        {
                return View(productRepo.Products.ToList());
        }

        public IActionResult Index()
        {
                //List<Product> model = db.Products.ToList();
                //return View(model);
                return View(productRepo.Products.ToList());
        }

        public IActionResult Details(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(products => products.ProductId == id);
            if (thisProduct.Reviews.Count() > 0)
            {
              thisProduct.GetAverage();
            }
            return View(thisProduct);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            //db.Products.Add(product);
            //db.SaveChanges();
            productRepo.Save(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            //db.Entry(product).State = EntityState.Modified;
            //db.SaveChanges();
            productRepo.Edit(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Product thisProduct = productRepo.Products.FirstOrDefault(products => products.ProductId == id);
            //db.Products.Remove(thisProduct);
            //db.SaveChanges();
            productRepo.Remove(thisProduct);
            return RedirectToAction("Index");
        }
    }
}
