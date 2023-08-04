using Microsoft.EntityFrameworkCore;
using TyresShopAPI.Interfaces;
using TyresShopAPI.Models;
using TyresShopAPI.Models.Customers;

namespace TyresShopAPI.Persistance
{
    public class Context : DbContext, IContext
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
