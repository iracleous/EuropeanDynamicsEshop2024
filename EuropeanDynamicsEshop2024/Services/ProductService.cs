using EuropeanDynamicsEshop2024.BusinessExceptions;
using EuropeanDynamicsEshop2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Services;

public class ProductService
{
    private Product _product;

    public ProductService(Product product)
    {
        _product = product;
    }

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
            Console.WriteLine("An error occured");
        }
    }

    public void Create(string productName, decimal price)
    {
        if(price > 100)
        {
            //Console.WriteLine($"cannot create create above 100");
            //  return;
            throw new ProductException();
        }
      _product = new Product()
        {
            Name = productName,
            Price = price
        };
    }

    public Product GetProduct()
    {
        return _product;
    }

}
