﻿using System;
using System.Collections.Generic;
using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using App.Infrastructures.Db.SqlServer.Ef.Configuration;

namespace App.Infrastructures.Db.SqlServer.Ef
{


public partial class EshopContext : IdentityDbContext<User, Role, int>
{

    public EshopContext(DbContextOptions<EshopContext> options): base(options)
    {
    }

    public DbSet<Admin> Admins { get; set; }

    public DbSet<Cart> Carts { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public  DbSet<Picture> Pictures { get; set; }

    public  DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AdminConfiguration());
        modelBuilder.ApplyConfiguration(new CartConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new PictureConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());

        base.OnModelCreating(modelBuilder);
    }


}
}