using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductID = 1, CategoryId = 2, ImageUrl = "/images/1.jpg", ProductName = "Computer", Price = 17_00, ShowCase = false },
                new Product() { ProductID = 2, CategoryId = 2, ImageUrl = "/images/2.jpg", ProductName = "Keyboard", Price = 11_00, ShowCase = false },
                new Product() { ProductID = 3, CategoryId = 2, ImageUrl = "/images/3.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductID = 4, CategoryId = 2, ImageUrl = "/images/4.jpg", ProductName = "Monitor", Price = 3_000, ShowCase = false },
                new Product() { ProductID = 5, CategoryId = 2, ImageUrl = "/images/5.jpg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                new Product() { ProductID = 6, CategoryId = 1, ImageUrl = "/images/6.jpg", ProductName = "History", Price = 50, ShowCase = false },
                new Product() { ProductID = 7, CategoryId = 1, ImageUrl = "/images/7.jpg", ProductName = "Hamlet", Price = 60, ShowCase = false },
                new Product() { ProductID = 8, CategoryId = 1, ImageUrl = "/images/8.jpg", ProductName = "Xp-Pen", Price = 1145, ShowCase = true },
                new Product() { ProductID = 9, CategoryId = 2, ImageUrl = "/images/9.jpg", ProductName = "Galaxy FE", Price = 4455, ShowCase = true },
                new Product() { ProductID = 10, CategoryId = 1, ImageUrl = "/images/10.jpg", ProductName = "Hp Mouse", Price = 545, ShowCase = true }

            );
        }
    }
}