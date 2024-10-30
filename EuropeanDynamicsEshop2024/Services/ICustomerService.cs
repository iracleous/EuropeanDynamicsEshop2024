using EuropeanDynamicsEshop2024.Models;

namespace EuropeanDynamicsEshop2024.Services;

public interface ICustomerService
{
    Customer CreateCustomer(Customer customer);
    bool DeleteCustomer(int id);
    Customer? ReadCustomer(int id);
    List<Customer> ReadCustomers();
    Customer? UpdateCustomer(Customer customer);
}