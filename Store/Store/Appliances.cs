using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Appliances:Product
    {

        public string Model { get; set; }

        public DateTime ProductionDate { get; set; }

        public double Weight { get; set; }

    }
}
