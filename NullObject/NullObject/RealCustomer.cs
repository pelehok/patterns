using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class RealCustomer:AbstractCustomer
    {
        public RealCustomer(string name){
            this.Name = name;
        }

        public override string GetName(){
            return Name;
        }

        public override bool IsNil(){
            return false;
        }
    }
}
