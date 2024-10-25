using EuropeanDynamicsEshop2024.Models;

Console.WriteLine("hello");

var product = new Product()
{
     Name ="tyri",
      Price = 10.56m,
       Quantity = 1,

};
Console.WriteLine($"product name = {product.Name} id = {product.Id}");

EshopDbContext db = new EshopDbContext();
db.Products.Add( product );
db.SaveChanges();

Console.WriteLine($"product name = {product.Name} id = {product.Id}");
