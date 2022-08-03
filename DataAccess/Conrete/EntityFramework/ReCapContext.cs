using Core.DataAccess.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conrete.EntityFramework
{
    public class ReCapContext : DbContext
    {      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB;Database=ReCapp;Trusted_Connection=true");
        }


        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaims> OperationClaims { get; set; }
        public DbSet<UserOperationClaims> UserOperationClaims { get; set; }
    }
}
