using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Models;

namespace ShopOnline.Data
{
    public class ShopOnlineContext : DbContext
    {
        public ShopOnlineContext (DbContextOptions<ShopOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<ShopOnline.Models.Category> Categories { get; set; } = default!;

        public DbSet<ShopOnline.Models.Product>? Products { get; set; }

        public DbSet<ShopOnline.Models.User>? Users { get; set; }
    }
}
