using joblistingsite.Models;
using Microsoft.EntityFrameworkCore;

namespace joblistingsite.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Jobs> tbl_job { get; set; }
        public DbSet<Testamonials> tbl_testamonials { get; set; }
        public DbSet<Category> tbl_category { get; set; }

    }
}
