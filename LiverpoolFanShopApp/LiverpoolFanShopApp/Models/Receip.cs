using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiverpoolFanShopApp.Models
{
    public class Receip
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
