using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_MVC.Models;

namespace ASP.NET_Core_MVC.Data
{
    public class ClothingContext : DbContext
    {
        public ClothingContext (DbContextOptions<ClothingContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_Core_MVC.Models.Clothing> Clothing { get; set; } = default!;
    }
}
