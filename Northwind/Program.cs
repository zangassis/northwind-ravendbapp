using Northwind.Model;
using Northwind.Raven;
using System;

namespace Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            string productId = "products/35-A";

            GetProduct(productId);
        }

        static void GetProduct(string id)
        {
            using (var session = DocumentStoreHolder.Store.OpenSession())
            {
                Product product = session.Load<Product>(id);

                Console.WriteLine($"Product: {product.Name} \t\t Price per Unit: {product.PricePerUnit}");
            }
        }
    }
}
