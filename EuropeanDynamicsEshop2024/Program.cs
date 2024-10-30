using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Repositories;
using EuropeanDynamicsEshop2024.Responses;
using EuropeanDynamicsEshop2024.Services;
using EuropeanDynamicsEshop2024.Validations;
using System.Net.Http.Headers;

Console.WriteLine("hello");
 

var customer = new Customer
{
    FistName = "George",
    Email = "geo@gmail.com"
};
EshopDbContext db = new EshopDbContext();
CustomerValidation validation = new CustomerValidation();
CustomerService customerService = new CustomerService(db, validation);


Console.WriteLine($"customer name = {customer.FistName} id = {customer.Id}");

customerService.CreateCustomer(customer);

Console.WriteLine($"customer name = {customer.FistName} id = {customer.Id}");

ResponseApi<Customer> customerResponse = customerService.ReadCustomer(1);

Console.WriteLine($"customer name = {customerResponse.Value?.FistName} id = {customerResponse.Value?.Id}");

Console.WriteLine("------Customers-----------");
customerService.ReadCustomers().ForEach(customer => Console.WriteLine(customer.Email));


