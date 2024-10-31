using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Responses;
using EuropeanDynamicsEshop2024.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EshopApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ILogger<ProductController> _logger;

    public ProductController(IProductService productService, ILogger<ProductController> logger)
    {
        _productService = productService;
        _logger = logger;
    }

    [HttpGet]
    public List<Product> GetProducts()
    {
        _logger.LogDebug("The method starts");
        return _productService.IndexProduct();
    }

    [HttpGet("{id}")]
    public List<Product> GetProducts(int id)
    {
        _logger.LogDebug("The method starts");
        return _productService.IndexProduct();
    }

    [HttpPost]
    public ResponseApi<Product> CreateProduct(Product product) {
        _logger.LogDebug("The method starts");
        return _productService.AddProduct(product);
    }

    [HttpPut]
    public ResponseApi<Product> UpdateProduct(Product product)
    {
        _logger.LogDebug("The method starts");
        return _productService.EditProduct(product);
    }

    [HttpDelete("{id}")]
    public bool DeleteProducts(int id)
    {
        _logger.LogDebug("The method starts");
        return _productService.DeleteProduct(id);
    }
}
 