using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiverpoolFanShopApp.Data;
using LiverpoolFanShopApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiverpoolFanShopApp.Controllers
{
    public class ProductsController : BaseController
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
            //var product = this.db.Products.FirstOrDefault(x => x.Id == id);
            var pictures = new List<Picture>
            {
                new Picture
                     {
                         Id = 1,
                         Name = "kit",
                         PathUrl = "/images/Categories/kit/manShirt.jpg",
                     }
            };
            var product2 = new Product
            {
                Id = 1,
                Name = "Gosho",
                Category = new Category
                {
                    Id = 1,
                    Name = "fan"
                },
                Price = 15.99m,
                Pictures = pictures,
            };
            return View(product2);
        }
    }
}
