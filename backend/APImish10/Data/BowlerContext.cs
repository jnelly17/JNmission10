using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace APImish10.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options){ }
        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Teams> Teams { get; set; }
        
    }
}
