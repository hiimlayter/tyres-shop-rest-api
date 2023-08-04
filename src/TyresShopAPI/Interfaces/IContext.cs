using Microsoft.EntityFrameworkCore;
using TyresShopAPI.Entites;
using TyresShopAPI.Entites.Customers;
using TyresShopAPI.Entities;
using TyresShopAPI.Models.Customers;

namespace TyresShopAPI.Interfaces
{
    public interface IContext
    {
        public DbSet<Tyre> Tyres { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Adress> Adresses { get; set; }

        public DbSet<OrderTyre> OrdersTyres { get; set; }

        Task<int> SaveChangesAsync();

    }
}
