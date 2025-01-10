using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductID { get; init; }
        [Required(ErrorMessage = "ProductName is required")]
        public String? ProductName { get; init; } = String.Empty;
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; init; }
        public string? Summary { get; init; } = String.Empty;
        public string? ImageUrl { get; set; } // atama işlemi sonradan yani dos. yükl sonra olcağı için set

        public int? CategoryId { get; init; }

    }
}