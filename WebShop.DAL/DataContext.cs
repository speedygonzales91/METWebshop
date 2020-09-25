using METWebShop.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace METWebShop.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });


            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Name = "Súlyzókészlet 2X2 KG",
                        ImagePath = "SULYZO.png",
                        Price = 7000,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 1
                    },
                    new Product
                    {
                        Name = "Haskerék",
                        ImagePath = "HASKEREK.png",
                        Price = 6000,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 2
                    },
                    new Product
                    {
                        Name = "Jógaszőnyeg",
                        ImagePath = "JOGASZONYEG.png",
                        Price = 8000,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 3
                    },
                    new Product
                    {
                        Name = "Mikroszálas törölköző 42 X 55 cm",
                        ImagePath = "TORULKOZO.png",
                        Price = 1400,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 4
                    },
                    new Product
                    {
                        Name = "Ugrókötél",
                        ImagePath = "UGROKOTEL.png",
                        Price = 4000,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 5
                    },
                    new Product
                    {
                        Name = "Pilates labda Átmérő: 26 cm",
                        ImagePath = "PILATESLABDA.png",
                        Price = 2400,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 6
                    },
                    new Product
                    {
                        Name = "Pilates karika Átmérő:40 cm",
                        ImagePath = "PILATESKARIKA.png",
                        Price = 8000,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 7
                    },
                    new Product
                    {
                        Name = "Fitball Átmérő:55 cm",
                        ImagePath = "FITBALL55CM.png",
                        Price = 6800,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 8
                    },
                    new Product
                    {
                        Name = "Fitball Átmérő:65 cm",
                        ImagePath = "FITBALL65CM.png",
                        Price = 7600,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 9
                    },
                    new Product
                    {
                        Name = "Fitball Átmérő:75 cm",
                        ImagePath = "FITBALL75CM.png",
                        Price = 8800,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 10
                    },
                    new Product
                    {
                        Name = "Fitball Átmérő:85 cm",
                        ImagePath = "FITBALL85 CM.png",
                        Price = 10000,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 11
                    },
                    new Product
                    {
                        Name = "Pilates pumpa",
                        ImagePath = "PILATES PUMPA.png",
                        Price = 8000,
                        ProductType = ProductCategoryType.WarmUpPack,
                        Id = 12
                    }
                );
        }
    }
}
