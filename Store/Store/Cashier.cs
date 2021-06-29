using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Cashier
    {
        public void PrintReceipt(List<Product> products, DateTime datePurchased)
        {
            Console.WriteLine($"Date: {datePurchased}");
            Console.WriteLine("---Products-- -");
            decimal totalSum = 0.0m;
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} {product.Brand}");
                Console.WriteLine($"{product.Quantity} x ${product.Price} = {(decimal)product.Quantity * product.Price}");
                totalSum += (decimal)product.Quantity * product.Price;
                if (product is Food || product is Bevarages)
                {
                    //product.IsExpired();
                }
                else if (product is Clothes)
                {
                    //
                }
                
            }
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine($"TOTAL: {totalSum}");


        }
    }
}
