using C__301EmptityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__301_DataAccesLayer.Context
{
    public class KampContext:DbContext
    {
        public DbSet<Category>  categories { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Admin> Admins { get; set; } 
    }
}
