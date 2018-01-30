﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBear.Models
{
    public class EFProductRepository : IProductRepository
    {
        GummiBearContext db = new GummiBearContext();


        public EFProductRepository()
        {
            db = new GummiBearContext();
        }

        public EFProductRepository(GummiBearContext thisDb)
        {
            db = thisDb;
        }

        public IQueryable<Product> Products
        { get { return db.Products; } }

        public Product Save(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }

        public Product Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return product;
        }

        public void Remove(Product product)
        {
            db.Products.Remove(product);
            db.SaveChanges();
        }

        public void DeleteAll()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM Products");
        }
    }
}