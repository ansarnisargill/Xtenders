using Microsoft.EntityFrameworkCore;
using XtendersProject.Models;

namespace XtendersProject.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<HomePageData> HomeData { get; set; }
        public DbSet<XtendersProject.Models.Quotation> Quotations { get; set; }
        public DbSet<XtendersProject.Models.AboutUs> AboutUs { get; set; }
        public DbSet<XtendersProject.Models.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        
    }
}
