using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Model;
using ProductApi.Services.Interface;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;
        
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet("list")]
        public ActionResult GetAllProducts()
        {
            _logger.LogInformation("Listing all products");
            return Ok(_productService.ListAllProducts());
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            try
            {
                _logger.LogInformation("Creating product");

                if (product == null)
                {
                    return BadRequest();
                }
                
                var createdProduct = _productService.CreateProduct(product);
                return createdProduct;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating product");
            }
        }
    }
}
