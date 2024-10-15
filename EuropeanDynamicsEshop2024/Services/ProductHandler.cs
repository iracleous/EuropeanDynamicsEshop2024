using EuropeanDynamicsEshop2024.Models;

namespace EuropeanDynamicsEshop2024.Services;

public static class ProductHandler
{
    private static readonly decimal vatPercentageBasic = 0.24m;
    private static readonly decimal vatPercentageReduced = 0.16m;
    private static readonly decimal vatPercentageMinimum = 0.04m;

    public static decimal ProductTotalCost(Product product)
    {
        switch (product.Category)
        {
            case Category.Uncategorized:
                return product.Price *
                (1 - product.DiscountPerCentPetItem) * product.Quantity
                * (1 + vatPercentageBasic);
            case Category.Food:
                return product.Price *
                    (1 - product.DiscountPerCentPetItem) * product.Quantity
                    * (1 + vatPercentageReduced);
            case Category.Beverage:
            case Category.Cloth:
            case Category.Furniture:
            default:
                return product.Price *
                    (1 - product.DiscountPerCentPetItem) * product.Quantity
                    * (1 + vatPercentageMinimum);
        }
    }
}
