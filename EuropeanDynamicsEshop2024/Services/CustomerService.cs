using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Repositories;
using EuropeanDynamicsEshop2024.Responses;
using EuropeanDynamicsEshop2024.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Services;

public class CustomerService : ICustomerService
{
    private readonly EshopDbContext db;
    private readonly ICustomerValidation validation;

    public CustomerService(EshopDbContext db, ICustomerValidation validation)
    {
        this.db = db;
        this.validation = validation;
    }

    //CRUD
    public ResponseApi<Customer> CreateCustomer(Customer customer)
    {
        if (!validation.CustomerValidator(customer))
            return new ResponseApi<Customer>
            {
                   Status = -4,
                   Description  = "invalid customer data"
            };

        db.Customers.Add(customer);
        db.SaveChanges();
        return new ResponseApi<Customer>
        {
            Status = 0,
            Description = "success",
            Value = customer
        };
    }
    public List<Customer> ReadCustomers()
    {
        return db.Customers.ToList();
    }

    public ResponseApi<Customer> ReadCustomer(int id)
    {
        Customer? customer = db.Customers.Where(c => c.Id == id).FirstOrDefault();
        if (customer == null)
        {
            return new ResponseApi<Customer>
            {
                Status = -3,
                Description = "cusromer not found",
            };
        }
        return new ResponseApi<Customer>
            {
                Status = 0,
                Description = "success",
                Value = customer
            };
    }


    public ResponseApi<Customer> UpdateCustomer(Customer customer)
    {

        Customer? customerdb = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
        if (customerdb != null)
        {
            customerdb.Email = customer.Email;
            db.SaveChanges();
        }
        return new ResponseApi<Customer>
        {
            Status = 0,
            Description = "success",
            Value = customerdb
        };
    }

    public bool DeleteCustomer(int id)
    {

        Customer? customerdb = db.Customers.FirstOrDefault(c => c.Id == id);
        if (customerdb != null)
        {
            db.Customers.Remove(customerdb);
            db.SaveChanges();
            return true;
        }
        return false;
    }

}
