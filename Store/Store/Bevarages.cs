using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Bevarages:PerishableProducts
    {
        public void IsExpired()
        {
            if ((ExpirationDate - DateTime.Now).TotalDays < 5)
            {
                Price = Price - (Price * 0.1m);
            }
            else if ((ExpirationDate - DateTime.Now).TotalDays == 0)
            {
                Price = Price - (Price * 0.5m);
            }
        }
    }
}
