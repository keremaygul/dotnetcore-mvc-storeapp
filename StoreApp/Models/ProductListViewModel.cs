using Entities.Models;

namespace StoreApp.Models
{
    class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();

        public Pagination Pagination { get; set; } = new();

        public int TotalCount => Products.Count();
    }
}