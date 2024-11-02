﻿using Microsoft.EntityFrameworkCore;
using SuperMarketWEB.Models;

namespace SuperMarketWEB.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PayMode> PayModes { get; set; }
        public DbSet<Providers> Providers { get; set; }
        
    }
}
