using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Item
{
    interface IItem
    {
        string name();
        IPacking packing();
        double price();

    }
}
