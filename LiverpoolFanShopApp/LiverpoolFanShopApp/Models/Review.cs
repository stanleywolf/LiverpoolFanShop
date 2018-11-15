using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiverpoolFanShopApp.Models
{
    public class Review
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public string LiverpoolUserId { get; set; }
        public virtual LiverpoolUser LiverpoolUser { get; set; }
    }
}
