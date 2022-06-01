using ASP_EternaDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_EternaDatabase.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Portfolio> Portfolios { get; set; }
        
        public DbSet<Category> Categories { get; set; }

        public DbSet<PortfolioImages> PortfolioImages { get; set; }
    }
}
