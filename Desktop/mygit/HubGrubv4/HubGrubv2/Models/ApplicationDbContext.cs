using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HubGrubv2.Models;

namespace HubGrubv2.Models
{
    public class ApplicationDbContext : IdentityDbContext<UserModel>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=tcp:hubgrubv220190317075008dbserver.database.windows.net,1433;Initial Catalog=HubGrubv220190317075008_db;Persist Security Info=False;User ID=hubgrubadmin;Password=Lab12345!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<HubGrubv2.Models.UserModel> UserModel { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=tcp:hubgrubv220190317075008dbserver.database.windows.net,1433;Initial Catalog=HubGrubv220190317075008_db;Persist Security Info=False;User ID=hubgrubadmin;Password=Lab12345!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<HubGrubv2.Models.RestaurantModel> RestaurantModel { get; set; }
        public DbSet<HubGrubv2.Models.DishModel> DishModel { get; set; }
        public DbSet<HubGrubv2.Models.CategoryModel> CatergoryModel { get; set; }
    }
}
