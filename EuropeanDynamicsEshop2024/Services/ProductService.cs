using EuropeanDynamicsEshop2024.BusinessExceptions;
using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Services;

public class ProductService : IProductService
{
    private Product _product;

    public ProductService(Product product)
    {
        _product = product;
    }
    /// <summary>
    /// saves the product to a file
    /// </summary>
    public void Save()
    {
        try
        {
            string filename = "c:/data2/dimitrisfile.txt";
            using StreamWriter outputFile = new StreamWriter(filename, true);
            outputFile.WriteLine($"{_product.Name},{_product.Price},{_product.Category}");
        }
        catch (Exception e)
        {
            //Console.WriteLine(e.ToString());
            Console.WriteLine("An error occured. The data has not been saved");
        }
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="productName"></param>
    /// <param name="price"></param>
    /// <exception cref="ProductException"></exception>
    public void CreateProducingException(string productName, decimal price)
    {
        if (price > 100 || price < 0)
        {
            //Console.WriteLine($"cannot create product with price above 100");
            //  return;
            throw new ProductException("cannot create product with price above 100");
        }
        _product = new Product()
        {
            Name = productName,
            Price = price
        };
    }

    public ImmutableProduct GetProduct()
    {
        return new ImmutableProduct(_product.Name, _product.Price, _product.Quantity);
    }




    public ProductResponse Create(string productName, decimal price)
    {
        if (price > 100 || price < 0)
        {
            return new ProductResponse
            {
                Message = "cannot create product with price above 100",
                Status = 2
            };
        }
        _product = new Product()
        {
            Name = productName,
            Price = price
        };
        return new ProductResponse
        {
            Message = "Success",
            Status = 0
        };
    }
}
