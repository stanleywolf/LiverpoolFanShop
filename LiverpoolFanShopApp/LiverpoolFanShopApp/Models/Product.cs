using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiverpoolFanShopApp.Models
{
    public class Product
    {
        public Product()
        {
            this.Ratings = new HashSet<Rating>();
            this.Reviews = new HashSet<Review>();
            this.Pictures = new HashSet<Picture>();
            this.OrdersProducts = new HashSet<OrdersProduct>();
        }
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335")]
        public decimal Price { get; set; }

        [Required]
        public string Name { get; set; }               

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }        

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }

        public double OverallRating => this.Ratings.Sum(x => x.Rate) / this.Ratings.Count();
        
    }  
}
