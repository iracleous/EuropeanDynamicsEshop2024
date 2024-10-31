using EuropeanDynamicsEshop2024.BusinessExceptions;
using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Repositories;
using EuropeanDynamicsEshop2024.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Services;

public class ProductService : IProductService
{
    private readonly EshopDbContext eshopDbContext;

    public ProductService(EshopDbContext eshopDbContext)
    {
        this.eshopDbContext = eshopDbContext;
    }

    public ResponseApi<Product> AddProduct(Product product)
    {
        eshopDbContext.Products.Add(product);
        eshopDbContext.SaveChanges();
        return new ResponseApi<Product>
        {
            Value = product,
            Description = "success",
            Status = 0
        };
    }

    public bool DeleteProduct(int id)
    {
        Product? product = eshopDbContext.Products.Find(id);
        if (product == null)
        {
            return false;
        }
        eshopDbContext.Products.Remove(product);
        return true;
    }

    public ResponseApi<Product> EditProduct(Product product)
    {
        Product? productDb = eshopDbContext.Products.Find(product.Id);
        if (productDb == null)
        {
            return new ResponseApi<Product> { Description="not such product", Status=-2};
        }
        productDb.Price = product.Price;
        eshopDbContext.SaveChanges();
        return new ResponseApi<Product> { Description = "success", Status = 0, Value = productDb }; ;
    }

    public ResponseApi<Product> IndexProduct(int id)
    {
        return new ResponseApi<Product>
        {
            Value = eshopDbContext.Products.Find(id)
        };
    }

    public List<Product> IndexProduct()
    {
        return eshopDbContext.Products.ToList();
    }
}
