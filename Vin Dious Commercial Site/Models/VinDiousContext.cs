using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vin_Dious_Commercial_Site.Models
{
    public class VinDiousContext : DbContext
    {
        public VinDiousContext(DbContextOptions<VinDiousContext> options)
            : base(options)
        {

        }
        public DbSet<CustomerAddressBase> CustomerAddressBase { get; set; }
        public DbSet<DiscountBase> DiscountBase { get; set; }
        public DbSet<OrdersBase> OrdersBase { get; set; }
        public DbSet<OrdersDetailsBase> OrdersDetailsBase { get; set; }
        public DbSet<OrdersInventoryBase> OrdersInventoryBase { get; set; }
        public DbSet<OrderStatusBase> OrderStatusBase { get; set; }
        public DbSet<ProductBase> ProductBase { get; set; }
        public DbSet<ProductBrandBase> ProductBrandBase { get; set; }
        public DbSet<ProductCategoryBase> ProductCategoryBase { get; set; }
        public DbSet<RoleBase> RoleBase { get; set; }
        public DbSet<SupplierBase> SupplierBase { get; set; }
        public DbSet<WebUserBase> WebUserBase { get; set; }
    }
}
