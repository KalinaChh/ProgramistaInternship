using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Food: PerishableProducts
    {
       public void IsExpired(DateTime dateProduced, DateTime datePurchase)
        {
            if ((dateProduced - datePurchase).TotalDays < 5)
            {
                Price = Price - (Price * 0.1m);
            }
            else if ((dateProduced - datePurchase).TotalDays == 0)
            {
                Price = Price - (Price * 0.5m);
            }
        }

    }
}
