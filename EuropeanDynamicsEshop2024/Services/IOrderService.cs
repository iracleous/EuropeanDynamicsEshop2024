using EuropeanDynamicsEshop2024.Models;

namespace EuropeanDynamicsEshop2024.Services
{
    public interface IOrderService
    {
        Order CreateOrder(int customerId);
    }
}