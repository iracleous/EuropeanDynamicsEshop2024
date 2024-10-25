using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Services;

public class CustomerService
{

    private EshopDbContext db;

    public CustomerService(EshopDbContext db)
    {
        this.db = db;
    }

    //CRUD
    public Customer CreateCustomer(Customer customer)
    {
        
        db.Customers.Add(customer);
        db.SaveChanges();
        return customer;
    }
    public List<Customer> ReadCustomers()
    {
        
        return db.Customers.ToList();
    }

    public Customer? ReadCustomer(int id)
    {
        
        return db.Customers.Where(c => c.Id==id).FirstOrDefault();
    }

  
    public Customer? UpdateCustomer(Customer customer) {
        
        Customer? customerdb = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
        if (customerdb != null)
        {
            customerdb.Email = customer.Email;
            db.SaveChanges();
        }
        return customerdb;
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
