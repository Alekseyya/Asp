Ageusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DomainModel.Entities;

namespace DomainModel.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Articul> Articuls { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Client> Clients { get; set; }
     
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Price> Prices { get; set; }
     

        public DbSet<Category> Categories { get; set; }

        
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
