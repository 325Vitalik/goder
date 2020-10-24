using Goder.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Goder.DAL.Context
{
    public class GoderContext : DbContext
    {
        public GoderContext(DbContextOptions<GoderContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Problem> Problems { get; set; }

    }
}