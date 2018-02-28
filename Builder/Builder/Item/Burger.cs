using Builder.Packing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Item
{
    abstract class Burger : IItem
    {
        public abstract string name();

        public IPacking packing()
        {
            return new Wrapper();
        }

        public abstract double price();
    }
}
