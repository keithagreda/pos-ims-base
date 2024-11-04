using Microsoft.EntityFrameworkCore;
using pos_ims_base.Models;

namespace pos_ims_base.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{

        //}
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalesHeader> SalesHeaders { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<StocksReceiving> StocksReceivings { get; set; }
        public DbSet<StockDamageHeader> StockDamageHeaders { get; set; }
        public DbSet<StockDamageDetail> StockDamageDetails { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
