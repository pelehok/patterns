using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    abstract class AbstractCustomer
    {
        protected string Name;

        public abstract string GetName();

        public abstract bool IsNil();
    }
}
