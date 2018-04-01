using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class NullCustomer:AbstractCustomer
    {
        public override string GetName(){
            return "Not Available in Customer Database";
        }

        public override bool IsNil(){
            return true;
        }
    }
}
