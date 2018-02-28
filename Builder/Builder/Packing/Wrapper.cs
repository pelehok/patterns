using Builder.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Packing
{
    class Wrapper : IPacking
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}
