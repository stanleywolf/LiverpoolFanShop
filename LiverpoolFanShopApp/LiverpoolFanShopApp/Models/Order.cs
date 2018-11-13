using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LiverpoolFanShopApp.Models
{
    public class Order
    {
        public Order()
        {
            this.OrdersProducts = new HashSet<OrdersProduct>();
        }
        public int Id { get; set; }

        public bool IsConfirmed  => false;

        public int LiverpoolUserId { get; set; }
        public virtual LiverpoolUser LiverpoolUser { get; set; }

        public int? ReceipId { get; set; }
        public virtual Receip Receip { get; set; }

        public ICollection<OrdersProduct> OrdersProducts { get; set; }

        [NotMapped]
        public decimal TotalPrice => this.OrdersProducts.Sum(x => x.Product.Price * x.Quantity);
    }
}
