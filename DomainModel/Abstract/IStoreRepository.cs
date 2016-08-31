using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;

namespace DomainModel.Abstract
{
    public interface IStoreRepository
    {

        IQueryable<Product> Products { get; }

        IQueryable<Brand> Brands { get; }
             
        IQueryable<Category> Categories { get; }
        IQueryable<Country> Countries { get; }
        IQueryable<Region> Regions { get; }
        IQueryable<Articul> Articuls { get; }
        IQueryable<Price> Prices { get; }
        IQueryable<Client> Clients { get; }

        IQueryable<Employee> Employees { get; }
        IQueryable<OrderItem> OrderItems { get; }
        
        IQueryable<City> Cities { get; }
        void UpdateCitiesById(City city);
        void AddCities(City city);
        City GetCitiesById(int Id);

    }
}
