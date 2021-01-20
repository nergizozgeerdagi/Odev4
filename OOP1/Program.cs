using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.Productname = "Sandalye";
            product1.Unitprice = 557;
            product1.UnitsInStock = 3;

            Product product2 = new Product{Id = 2, CategoryId = 1, Productname = "Kalem", UnitsInStock = 9, Unitprice = 12};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

           



        
        
        }
    }
}
