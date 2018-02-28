using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Item
{
    class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg Burger";
        }

        public override double price()
        {
            return 25.0;
        }
    }
}
