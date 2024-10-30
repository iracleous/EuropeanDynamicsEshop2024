using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Responses;

namespace EuropeanDynamicsEshop2024.Services;

public interface ICustomerService
{
    ResponseApi<Customer> CreateCustomer(Customer customer);
    bool DeleteCustomer(int id);
    ResponseApi<Customer> ReadCustomer(int id);
    List<Customer> ReadCustomers();
    ResponseApi<Customer> UpdateCustomer(Customer customer);
}