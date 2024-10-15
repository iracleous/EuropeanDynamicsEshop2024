using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public Category Category { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; } = 1;
    public decimal DiscountPerCentPetItem { get; set; }
    public ProductSupplier? Supplier { get; set; }
    public decimal TotalBeforeTaxes => Price*(1 - DiscountPerCentPetItem)  * Quantity;
}
