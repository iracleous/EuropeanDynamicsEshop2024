// See https://aka.ms/new-console-template for more information
using EuropeanDynamicsEshop2024.Models;

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
    Id = 102
};