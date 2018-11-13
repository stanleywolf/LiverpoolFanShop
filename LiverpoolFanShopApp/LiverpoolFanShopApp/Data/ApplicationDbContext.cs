using System;
using System.Collections.Generic;
using System.Text;
using LiverpoolFanShopApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LiverpoolFanShopApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<LiverpoolUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrdersProduct> OrdersProducts { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Receip> Receips { get; set; }
        public DbSet<Review> Reviews { get; set; }

        //TODO: 'new' i don't now
        //public new DbSet<LiverpoolUser> Users { get; set; }


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

            base.OnModelCreating(builder);
        }
    }
}
