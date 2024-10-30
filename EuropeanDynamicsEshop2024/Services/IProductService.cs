using EuropeanDynamicsEshop2024.Responses;

namespace EuropeanDynamicsEshop2024.Services;

public interface IProductService
{
    ProductResponse Create(string productName, decimal price);
    void CreateProducingException(string productName, decimal price);
    ImmutableProduct GetProduct();
    void Save();
}