using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Models;


/// <summary>
/// 
///
/// 
/*
   Product
	Id, Name, Price, Category, Description, Color, Size, Weight, Stock
Customer
    Id, FistName, LastName, [Email], RegistrationDate, Active, [Address], Password, [Orders]
Order
    Id, <Customer>, [Product], OrderDate, TotalAmount
*/
/// 
/// </summary>

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public Category Category { get; set; }
    [Precision(8,2)]
    public decimal Price { get; set; }
    public int Quantity { get; set; } = 1;
    [Precision(8, 2)]
    public decimal DiscountPerCentPetItem { get; set; }
    [Precision(8, 2)]
    public decimal TotalBeforeTaxes => Price*(1 - DiscountPerCentPetItem)  * Quantity;
    public string? Size { get; set; }
    [Precision(8, 2)]
    public decimal Weight { get; set; }
    public int Stock {  get; set; }
    public List<Order> Orders { get; set; } = [];
    public Supplier? Supplier { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string FistName { get; set; }= string.Empty;
    public string  LastName { get; set; }= string.Empty;
    public string Email { get; set; }= string.Empty; 
    public DateTime RegistrationDate { get; set; }
    public bool    Active { get; set; }
    public List<Order> Orders { get; set; } = [];
    
}

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public Customer? Customer { get; set; }
    public List<Product> Products { get; set; } = [];
}

public class Supplier
{
    public int Id { get; set; }
    public string FistName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; }
    public bool Active { get; set; }
    public List<Product> Products { get; set; } = [];
}