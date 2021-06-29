using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Food apples = new Food();
            apples.Name = "apples";
            apples.Brand = "BrdandA";
            apples.Price = 1.5m;
            apples.Quantity = 2.24;
            apples.ExpirationDate = new DateTime(2021, 06, 14);

            Bevarages milk = new Bevarages();
            milk.Name = "milk";
            milk.Brand = "BrdandM";
            milk.Price = 0.99m;
            milk.Quantity = 3;
            milk.ExpirationDate = new DateTime(2022, 02, 02);

            Clothes tShirt = new Clothes();
            tShirt.Name = "T-shirt";
            tShirt.Brand = "BrdandT";
            tShirt.Price = 15.99m;
            tShirt.Size = "M";
            tShirt.Quantity = 2;
            tShirt.Color = "violet";

            Appliances laptop = new Appliances();
            laptop.Name = "laptop";
            laptop.Brand = "BrdandL";
            laptop.Price = 2345m;
            laptop.Model = "ModelL";
            laptop.Quantity = 1;
            laptop.ProductionDate = new DateTime(2021, 03, 03);
            laptop.Weight = 1.125;

            List<Product> products = new List<Product>();
            products.Add(apples);
            products.Add(milk);
            products.Add(tShirt);
            products.Add(laptop);
 
            DateTime datePurchase = new DateTime(2021, 06, 14, 12, 34, 56);

            Cashier cashier = new Cashier();
            cashier.PrintReceipt(products, datePurchase);
        }
    }
}
