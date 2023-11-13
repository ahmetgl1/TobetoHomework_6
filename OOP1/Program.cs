using OOP1.Entities;
using OOP1.Services;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product()
            {
                Id = 1,
                CategoryId = 5,
                ProductName = "Masa",
                UnitPrice = 355.0,
                UnitsInStock = 94,

            };

            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 7,
                ProductName = "Sandalye",
                UnitPrice = 125.0,
                UnitsInStock = 12,

            };
            Product product3 = new Product()
            {
                Id = 3,
                CategoryId = 4,
                ProductName = "Oyuncak",
                UnitPrice = 70.0,
                UnitsInStock = 43,

            };


            ProductService productService = new ProductService();   
            productService.Add(product3);    
            productService.Add(product2);    
            productService.Add(product1);   
            










        }
    }
}