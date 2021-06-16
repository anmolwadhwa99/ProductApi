using System.Collections.Generic;
using ProductApi.Dtos;

namespace ProductApi.Services.Interface
{
    public interface IProductService
    {
        IList<ProductDto> ListAllProducts();
    }
}
