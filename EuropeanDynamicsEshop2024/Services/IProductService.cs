using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Responses;
using System.Numerics;

namespace EuropeanDynamicsEshop2024.Services;

public interface IProductService
{
    ResponseApi<Product> AddProduct(Product product);
    ResponseApi<Product> IndexProduct(int id);
    List<Product> IndexProduct();
    ResponseApi<Product> EditProduct(Product product);
    bool DeleteProduct(int id);
}