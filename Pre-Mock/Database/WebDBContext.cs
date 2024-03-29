﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pre_Mock.Models.Orders;
using Pre_Mock.Models.Products;
using Pre_Mock.Models.Users;

namespace Pre_Mock.Database
{
    public class WebDBContext : DbContext
    {
        public WebDBContext() { }
        public WebDBContext(DbContextOptions<WebDBContext> options) : base(options) { }
        DbSet<Order> orders { get; set; }
        DbSet<OrderDetails> orderDetails { get; set; }
        DbSet<Category> categories { get; set; }
        DbSet<Program> programs { get; set; }
        DbSet<BuyUser> buyUsers { get; set; }
        DbSet<Role> roles { get; set; }
        DbSet<User> users { get; set; }
        DbSet<UserDetails> userDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:WebDb");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);
        }
    }
}
