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
        }
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int PictureId { get; set; }
        public Picture Picture { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public double OverallRating()
        {
            double sum = 0;
            foreach (var rating in Ratings)
            {
                sum += rating.Rate;
            }

            sum = sum / this.Ratings.Count();
            return sum;
        }
    }  
}
