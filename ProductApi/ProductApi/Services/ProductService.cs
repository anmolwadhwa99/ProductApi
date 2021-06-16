using System.Collections.Generic;
using System.Linq;
using ProductApi.Dtos;
using ProductApi.Model;
using ProductApi.Repositories.Interface;
using ProductApi.Services.Interface;

namespace ProductApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public IList<ProductDto> ListAllProducts()
        {
            var productList = _productRepository.ListAllProducts();
            return productList.Select(ProductDto.MapFrom).ToList();
        }

        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }
    }
}
