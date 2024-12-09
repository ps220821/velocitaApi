using Microsoft.EntityFrameworkCore;
using velocitaApi.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;


namespace velocitaApi.data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser> // changed from DBcontext -> IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalCost)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Car)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.carId)
                .OnDelete(DeleteBehavior.SetNull);

            // modelBuilder.Entity<Order>()
            //     .HasOne(o => o.User)
            //     .WithMany(u => u.Orders)
            //     .HasForeignKey(o => o.processedByUserId)
            //     .OnDelete(DeleteBehavior.SetNull);

            // Convert orderStatus and serviceType to string
            modelBuilder.Entity<Order>()
                .Property(o => o.OrderStatus)
                .HasConversion<string>();

            modelBuilder.Entity<Order>()
                .Property(o => o.ServiceType)
                .HasConversion<string>();

            // Timestamp settings
            modelBuilder.Entity<Order>()
                .Property(o => o.CreatedAt)
                .HasDefaultValueSql("GETDATE()")
                .HasColumnType("DATETIME2");

            modelBuilder.Entity<Order>()
                .Property(o => o.UpdatedAt)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .HasColumnType("DATETIME2")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            // carspec table
            modelBuilder.Entity<CarSpec>()
                .HasOne(cs => cs.Car)
                .WithMany(c => c.CarSpecs)
                .HasForeignKey(cs => cs.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            // carspec enums 
            // Store Transmission as a string
            modelBuilder.Entity<CarSpec>()
                .Property(c => c.Transmission)
                .HasConversion<string>();

            // Store DriveTrain as a string
            modelBuilder.Entity<CarSpec>()
                .Property(c => c.DriveTrain)
                .HasConversion<string>();

            // Store FuelType as a string
            modelBuilder.Entity<CarSpec>()
                .Property(c => c.FuelType)
                .HasConversion<string>();
        }
        // table sets
        public DbSet<Car> car { get; set; } = null!;
        public DbSet<Brand> brand { get; set; } = null!;
        public DbSet<Customer> customer { get; set; } = null!;
        public DbSet<Category> category { get; set; } = null!;
        public DbSet<Order> order { get; set; } = null!;
        public DbSet<Option> options { get; set; } = null!;
        public DbSet<CarOption> CarOptions { get; set; } = null!;
        public DbSet<CarSpec> CarSpecs { get; set; } = null!;
    }
}
