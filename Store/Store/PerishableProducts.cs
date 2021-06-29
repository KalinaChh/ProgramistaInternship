using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class PerishableProducts: Product
    {
        public DateTime  ExpirationDate { get; set; }
    }
}
