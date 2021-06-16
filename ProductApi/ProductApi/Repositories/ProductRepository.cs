using System.Collections.Generic;
using ProductApi.Model;
using ProductApi.Repositories.Interface;

namespace ProductApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> ListAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Description = "Shampoo that washes your hair",
                    Name = "Loreal Shampoo",
                    Price = 8.50m,
                    StockLevel = 300
                },
                new Product
                {
                    Id = 2,
                    Description = "Bread loaf",
                    Name = "Bread",
                    Price = 4.50m,
                    StockLevel = 100
                },
                new Product
                {
                    Id = 3,
                    Description = "Dry fruit for snacking",
                    Name = "Dry fruit mix",
                    Price = 2.50m,
                    StockLevel = 500
                }
            };
        }
    }
}
