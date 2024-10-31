using EuropeanDynamicsEshop2024.Dtos;
using EuropeanDynamicsEshop2024.Models;

namespace EuropeanDynamicsEshop2024.Services
{
    public interface IOrderService
    {
        OrderDto CreateOrder(int customerId);
    }
}