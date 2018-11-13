using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiverpoolFanShopApp.Models
{
    public class Picture
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PathUrl { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
