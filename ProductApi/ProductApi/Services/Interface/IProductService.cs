using System.Collections.Generic;
using ProductApi.Dtos;
using ProductApi.Model;

namespace ProductApi.Services.Interface
{
    public interface IProductService
    {
        IList<ProductDto> ListAllProducts();
        Product CreateProduct(Product product);
    }
}
