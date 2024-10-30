using EuropeanDynamicsEshop2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Validations;

public class CustomerValidation : ICustomerValidation
{
    public bool CustomerValidator(Customer customer)
    {
        if (customer == null)
            return false;
        if (customer.Email == null || customer.Email.Contains("gmail.com"))
            return false;
        if (customer.Country == null || !customer.Country.Equals("Greece"))
            return false;
        return true;
    }
}
