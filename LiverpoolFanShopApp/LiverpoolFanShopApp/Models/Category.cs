using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiverpoolFanShopApp.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
