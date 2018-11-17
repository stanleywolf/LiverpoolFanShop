using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiverpoolFanShopApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace LiverpoolFanShopApp.Controllers
{
    public class ProductsController:BaseController
    {
        private readonly ApplicationDbContext db;

        public ProductsController(ApplicationDbContext context)
        {
            this.db = context;
        }
        public IActionResult All()
        {
            var products = this.db.Products.ToList();
            
            return View(products);
        }
        public IActionResult Index(int id = 23)
        {
            var product = this.db.Products.FirstOrDefault(x => x.Id == id);

            return View(product);
        }
    }
}
