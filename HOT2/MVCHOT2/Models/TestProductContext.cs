using Microsoft.EntityFrameworkCore;
namespace MVCHOT2.Models
{
    public class TestProductContext : DbContext
    {
        public DbSet<TestProduct> TestProducts { get; set; } = null!;
        
        public DbSet<Category> Categories { get; set; } = null!;

        public TestProductContext(DbContextOptions<TestProductContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = "ACC", CategoryName = "Accessories"},
                new Category() { CategoryId = "BIK", CategoryName = "Bikes" },
                new Category() { CategoryId = "CLO", CategoryName = "Clothing" },
                new Category() { CategoryId = "COM", CategoryName = "Components" },
                new Category() { CategoryId = "CAR", CategoryName = "Car racks" },
                new Category() { CategoryId = "WHE", CategoryName = "Wheels" }
                );

            modelBuilder.Entity<TestProduct>().HasData(
                new TestProduct() { TestProductId = 1, ProductName = "AeroFlo ATB Wheels", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 189, ProductQuantity = 40, CategoryId = "COM" },
                new TestProduct() { TestProductId = 2, ProductName = "Clear Shade 85-T Glasses", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 45, ProductQuantity = 14, CategoryId = "ACC" },
                new TestProduct() { TestProductId = 3, ProductName = "Cosmic Elite Road Warrior Wheels", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 165, ProductQuantity = 22, CategoryId = "COM" },
                new TestProduct() { TestProductId = 4, ProductName = "Cycle-Doc Pro Repair Stand", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 166, ProductQuantity = 12, CategoryId = "ACC" },
                new TestProduct() { TestProductId = 5, ProductName = "Dog Ear Aero-Flow Floor Pump", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 5, ProductQuantity = 25, CategoryId = "ACC" },
                new TestProduct() { TestProductId = 6, ProductName = "Dog Ear Cycle Computer", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 75, ProductQuantity = 20, CategoryId = "ACC" },
                new TestProduct() { TestProductId = 7, ProductName = "Dog Ear Helmet Mount Mirrors", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 7.45, ProductQuantity = 12, CategoryId = "ACC" },
                new TestProduct() { TestProductId = 8, ProductName = "Dog Ear Monster Grip Gloves", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 15, ProductQuantity = 30, CategoryId = "ACC" },
                new TestProduct() { TestProductId = 9, ProductName = "Eagle FS-3 Mountain Bike", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 1800, ProductQuantity = 8, CategoryId = "BIK" },
                new TestProduct() { TestProductId = 10, ProductName = "Eagle SA-120 Clipless Pedals", ProductDescShort = " ", ProductDescLong = "", ProductImage = "", ProductPrice = 139.95, ProductQuantity = 20, CategoryId = "COM" }
                );
        }
    }
}
