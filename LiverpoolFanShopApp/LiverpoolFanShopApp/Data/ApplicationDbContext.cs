using System;
using System.Collections.Generic;
using System.Text;
using LiverpoolFanShopApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LiverpoolFanShopApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrdersProduct>()
                .HasKey(x => new { x.ProductId, x.OrderId });

            builder.Entity<OrdersProduct>()
                .HasOne(x => x.Product)
                .WithMany(x => x.OrdersProducts)
                .HasForeignKey(x => x.ProductId);

            builder.Entity<OrdersProduct>()
                .HasOne(x => x.Order)
                .WithMany(x => x.OrdersProducts)
                .HasForeignKey(x => x.OrderId);

            builder.Entity<Order>()
                .HasOne(x => x.Receip)
                .WithOne(x => x.Order)
                .HasForeignKey<Receip>(x => x.OrderId);
        }
    }
}
