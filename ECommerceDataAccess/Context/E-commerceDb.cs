using ECommerceDataModels.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDataAccess.Context
{
    public class E_commerceDb: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr = "Data Source=DESKTOP-ASUS\\SQLEXPRESS;Initial Catalog=ECommerce;Integrated Security=True;Connect Timeout=30;Trust Server Certificate=False;";
            
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(constr);
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set;}
    }
}
