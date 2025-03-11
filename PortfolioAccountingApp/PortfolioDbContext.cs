using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAccountingApp
{
    public class PortfolioDbContext : DbContext
    {
        public DbSet<Position> Positions { get; set; }

        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }
    }
}
