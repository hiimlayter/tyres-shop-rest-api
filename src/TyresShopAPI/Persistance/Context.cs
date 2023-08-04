using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TyresShopAPI.Entites;
using TyresShopAPI.Entites.Customers;
using TyresShopAPI.Entities;
using TyresShopAPI.Interfaces;
using TyresShopAPI.Models.Customers;

namespace TyresShopAPI.Persistance
{
    public class Context : IdentityDbContext, IContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tyre> Tyres { get; set; } = null!;

        public DbSet<Producer> Producers { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Adress> Adresses { get; set; } = null!;

        public DbSet<OrderTyre> OrdersTyres { get; set; } = null!;

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync(new());
        }

    }
}
