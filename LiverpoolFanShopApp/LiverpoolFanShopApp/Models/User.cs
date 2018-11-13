using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LiverpoolFanShopApp.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            this.Ratings = new HashSet<Rating>();
            this.Reviews = new HashSet<Review>();
            this.Orders = new HashSet<Order>();
        }
        public ICollection<Order> Orders { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
