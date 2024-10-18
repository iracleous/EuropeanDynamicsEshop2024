// See https://aka.ms/new-console-template for more information
using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Services;
using System.Security.Authentication;

Console.WriteLine("Hello, World!");

var supplier = new ProductSupplier()
{
    Email = "supplier@naxos.gr",
    Id = 140,
    Name = "Naxiotis",
    StartDate = DateTime.Now,
};

var productPatates = new Product()
{
    Name = "patates",
    Category = Category.Food,
    Description = "Naxou",
    Supplier = supplier,
    Id = 101
};

var productChips = new Product()
{
    Name = "chips",
    Category = Category.Food,
    Description = "Snack",
    Supplier = new ProductSupplier()
    {
        Email = "supplier@tsakiris.gr",
        Id = 142,
        Name = "Industry",
        StartDate = DateTime.Now,
    },
    Id = 102,
    Price = 1.20m,
    Quantity = 4, 
    DiscountPerCentPetItem = 0.2m,
};

//Console.Write("give the chips price: ");
//string? price = Console.ReadLine();

//productChips.Price = decimal.Parse(price);

Console.WriteLine($"Total price for chips = {ProductHandler.ProductTotalCost(productChips)}");
Console.WriteLine($"Total price for patates = {ProductHandler.ProductTotalCost(productPatates)}");



var productService = new ProductService(productChips);

productService.Save();

productService.Create("fakes", 12.30m);
Console.WriteLine(productService.GetProduct().Name);

