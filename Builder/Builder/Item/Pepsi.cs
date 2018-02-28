using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Item
{
    class Pepsi : ColdDrink
    {
        public override string name()
        {
            return "Pepsi";
        }

        public override double price()
        {
            return 35.0;
        }
    }
}
