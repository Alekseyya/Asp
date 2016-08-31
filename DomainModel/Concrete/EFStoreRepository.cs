using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;
using DomainModel.Abstract;

namespace DomainModel.Concrete
{
    public class EFStoreRepository : IStoreRepository
    {
        private EFDbContext _context;
        public EFStoreRepository()
        {
            _context = new EFDbContext();
        }


        public IQueryable<Category> Categories
        {
            get { return _context.Categories; }
        }
        public IQueryable<Employee> Employees
        {
            get { return _context.Employees; }
        }
        public IQueryable<Client> Clients 
        {
            get { return _context.Clients.ToList().AsQueryable(); } 
        }


        public IQueryable<Articul> Articuls
        {
            get { return _context.Articuls.ToList().AsQueryable(); }
        }
        public IQueryable<Product> Products
        {
            get { return _context.Products.Include("Brand"); }
        }
        void AddProducts(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        //void UpdateProductsById(Product product)
        //{
        //    if (product.Id == 0)
        //    {
        //        _context.Products.Add(product);
        //    }
        //    else
        //    {
        //        Product dbProduct = _context.Products.Find(product.Id);
        //        if (dbProduct != null)
        //        {
        //            dbProduct.Id = product.Id;
        //            dbProduct.Description = product.Description;
        //            dbProduct.Price = product.Price;
        //            dbProduct.Availability = product.Availability;
        //            dbProduct.Quantity = product.Quantity;
        //            dbProduct.Brand = product.Brand;
        //            dbProduct.Categories = product.Categories;
        //            dbProduct.OrderItem = product.OrderItem;
                    
        //        }
        //    }
        //    _context.SaveChanges();
        //}
        //void RemoveProductsById(Product product)
        //{
        //    _context.Products.Remove(product);
        //    _context.SaveChanges();
        //}
        public IQueryable<Region> Regions
        {
            get { return _context.Regions.Include("Countries"); }

        }
        public IQueryable<Brand> Brands
        {
            get { return _context.Brands; }

        }
        public IQueryable<Price> Prices
        {
            get { return _context.Prices; }

        }
        
        public IQueryable<OrderItem> OrderItems
        {
            get { return _context.OrderItems.Include("Order"); }
        }

        public IQueryable<Country> Countries
        {
            get { return _context.Countries.ToList().AsQueryable(); }
        }
        public IQueryable<City> Cities
        {
            get { return _context.Cities.ToList().AsQueryable(); }

        }
        public City GetCitiesById(int Id)
        {
            return _context.Cities.Find(Id);
        }

        public void UpdateCitiesById(City city)
        {
            if(city.Id ==0)
            {
                _context.Cities.Add(city);
            }
            else
            {
                City dbCity = _context.Cities.Find(city.Id);
                if(dbCity !=null)
                {
                    dbCity.Id = city.Id;
                    dbCity.Name = city.Name;
                  
                    dbCity.RegionId = city.RegionId;
                }
            }
            _context.SaveChanges();
        }

        public void AddCities(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }




       
    }
}
