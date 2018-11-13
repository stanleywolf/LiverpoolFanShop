using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace LiverpoolFanShopApp.Models
{
    public class LiverpoolUser:IdentityUser
    {
        public LiverpoolUser()
        {
            this.Ratings = new HashSet<Rating>();
            this.Reviews = new HashSet<Review>();
            this.Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; } 

        public string LastName { get; set; } 

        public ICollection<Order> Orders { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        
    }

   
    
}
