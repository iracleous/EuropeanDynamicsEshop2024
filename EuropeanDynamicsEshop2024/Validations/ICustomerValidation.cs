using EuropeanDynamicsEshop2024.Models;

namespace EuropeanDynamicsEshop2024.Validations
{
    public interface ICustomerValidation
    {
        bool CustomerValidator(Customer customer);
    }
}