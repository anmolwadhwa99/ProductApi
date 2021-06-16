using System.Collections.Generic;
using ProductApi.Model;

namespace ProductApi.Repositories.Interface
{
    public interface IProductRepository
    {
        IList<Product> ListAllProducts();
    }
}
