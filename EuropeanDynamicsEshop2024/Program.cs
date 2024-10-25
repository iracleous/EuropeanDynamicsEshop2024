using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Repositories;
using EuropeanDynamicsEshop2024.Services;
using System.Net.Http.Headers;

Console.WriteLine("hello");
 

var customer = new Customer
{
    FistName = "George",
    Email = "geo@gmail.com"
};
EshopDbContext db = new EshopDbContext();
CustomerService customerService = new CustomerService(db);


Console.WriteLine($"customer name = {customer.FistName} id = {customer.Id}");

customerService.CreateCustomer(customer);

Console.WriteLine($"customer name = {customer.FistName} id = {customer.Id}");

Customer? customerDim = customerService.ReadCustomer(1);

Console.WriteLine($"customer name = {customerDim?.FistName} id = {customerDim?.Id}");

Console.WriteLine("------Customers-----------");
customerService.ReadCustomers().ForEach(customer => Console.WriteLine(customer.Email));


