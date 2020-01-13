using Microsoft.EntityFrameworkCore;
using XtendersProject.Models;

namespace XtendersProject.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<HomePageData> HomeData { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
